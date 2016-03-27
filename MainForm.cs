using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace PacketkeysGenerator
{
    public partial class MainForm : Form
    {
        struct clif_PacketKey
        {
            public long first_key;
            public long second_key;
            public long third_key;
        }

        ArrayList m_PassedKey = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 在窗口的标题显示出版本号
            FileVersionInfo myFileVersion = FileVersionInfo.GetVersionInfo(System.Windows.Forms.Application.ExecutablePath);
            this.Text = this.Text + " v." + myFileVersion.FileVersion;
        }

        // 生成一个随机的 PacketKey，不超过 0x7FFFFFFFF
        private long GenericRandKey()
        {
            Thread.Sleep(3);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            long nRet;
            nRet = (long)Math.Floor(ran.NextDouble() * 1000000000D);
            while (nRet >= 0x7FFFFFFF)
            {
                nRet = (long)Math.Floor(ran.NextDouble() * 1000000000D);
            }
            return nRet;
        }

        // 生成一组随机的PacketKey(一组有3个)
        private void GenericRandKeyGroup(out clif_PacketKey packetKey)
        {
            packetKey.first_key = GenericRandKey();
            packetKey.second_key = GenericRandKey();
            packetKey.third_key = GenericRandKey();
        }

        // 将一个PacketKey转换成16进制文本（不带0x开头的）
        private string Key2Str(long lKey)
        {
            return string.Format("{0:x8}", lKey);
        }

        // 初始化玩家的第一个对称密钥
        private long InitSDcryptKey(clif_PacketKey packetKey)
        {
            long cryptKey = (((((packetKey.first_key * packetKey.second_key) + packetKey.third_key) & 0xFFFFFFFF)
                * packetKey.second_key) + packetKey.third_key) & 0xFFFFFFFF;

            return cryptKey;
        }

        // 更新玩家的对称密钥
        private long UpdatecryptKey(long cryptKey, clif_PacketKey packetKey)
        {
            long newcryptKey = ((cryptKey * packetKey.second_key) + packetKey.third_key) & 0xFFFFFFFF;
            return newcryptKey;
        }

        // 对称密钥转换成用来进行按位异或的值
        private long GetBitXorValue(long cryptKey)
        {
            long bxv = ((cryptKey >> 16) & 0x7FFF);
            return bxv;
        }

        private bool StressTestingPacketKey(clif_PacketKey packetKey, long tCount)
        {
            long cryptKey;
            long bxv, lbxv;

            cryptKey = InitSDcryptKey(packetKey);
            lbxv = 0;

            for (int i = 0; i < tCount; i++)
            {
                cryptKey = UpdatecryptKey(cryptKey, packetKey);
                bxv = GetBitXorValue(cryptKey);
                if (lbxv != bxv)
                {
                    lbxv = bxv;
                    continue;
                }
                if (lbxv == bxv)
                {
                    return false;
                }
            }

            return true;
        }

        private void GenericNiceKeyGroup(out clif_PacketKey packetKey, bool bisTwo)
        {
            packetKey.first_key = GenericRandKey();
            packetKey.second_key = GenericRandKey();
            packetKey.third_key = GenericRandKey();
            if (bisTwo)
            {
                packetKey.second_key = packetKey.third_key;
            }

            while (!StressTestingPacketKey(packetKey, 5000))
            {
                packetKey.first_key = GenericRandKey();
                packetKey.second_key = GenericRandKey();
                packetKey.third_key = GenericRandKey();
                if (bisTwo)
                {
                    packetKey.second_key = packetKey.third_key;
                }
            }
        }

        private void btnGeneric_Click(object sender, EventArgs e)
        {
            clif_PacketKey packetKey;
            GenericNiceKeyGroup(out packetKey, cbCreateLastSameKey.Checked);
            txtGenericFirstKey.Text = Key2Str(packetKey.first_key);
            txtGenericSecondKey.Text = Key2Str(packetKey.second_key);
            txtGenericThirdKey.Text = Key2Str(packetKey.third_key);
            txtGenericPacketKeyGroup.Text = string.Format("0x{0},0x{1},0x{2}", Key2Str(packetKey.first_key),
                Key2Str(packetKey.second_key), Key2Str(packetKey.third_key));

            txtStressFirstKey.Text = txtGenericFirstKey.Text;
            txtStressSecondKey.Text = txtGenericSecondKey.Text;
            txtStressThirdKey.Text = txtGenericThirdKey.Text;
        }

        private void AppendTextToLog(string szLine)
        {
            txtStressLog.AppendText(szLine);
        }

        private void btnStressTest_Click(object sender, EventArgs e)
        {
            long cryptKey;
            long bxv, lbxv;
            bool bIsPassed = true;
            clif_PacketKey packetKey;

            btnStressTest.Enabled = false;

            if (string.IsNullOrWhiteSpace(txtStressFirstKey.Text) ||
                string.IsNullOrWhiteSpace(txtStressSecondKey.Text) ||
                string.IsNullOrWhiteSpace(txtStressThirdKey.Text))
            {
                MessageBox.Show(this, "请先填写要测试的三组密钥！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStressFirstKey.Focus();
                btnStressTest.Enabled = true;
                return;
            }

            Application.DoEvents();
            
            txtStressLog.Text = "";
            pBar.Value = 0;

            try
            {
                packetKey.first_key = Convert.ToInt64(txtStressFirstKey.Text, 16);
                packetKey.second_key = Convert.ToInt64(txtStressSecondKey.Text, 16);
                packetKey.third_key = Convert.ToInt64(txtStressThirdKey.Text, 16);
            }
            catch
            {
                MessageBox.Show(this, "密钥格式不正确，请填写类似：0x0d6be211 格式的密钥！\n或者前面的0x标记不带也是可以的！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStressFirstKey.Focus();
                btnStressTest.Enabled = true;
                return;
            }

            AppendTextToLog(string.Format("==============================\r\n"));
            AppendTextToLog(string.Format("第一个密钥：0x{0}\r\n", Key2Str(packetKey.first_key)));
            AppendTextToLog(string.Format("第二个密钥：0x{0}\r\n", Key2Str(packetKey.second_key)));
            AppendTextToLog(string.Format("第三个密钥：0x{0}\r\n", Key2Str(packetKey.third_key)));
            AppendTextToLog(string.Format("==============================\r\n"));
            AppendTextToLog(string.Format("\r\n"));

            cryptKey = InitSDcryptKey(packetKey);
            lbxv = 0;

            pBar.Maximum = 5000;
            for (int i = 0; i < 5000; i++)
            {
                cryptKey = UpdatecryptKey(cryptKey, packetKey);
                bxv = GetBitXorValue(cryptKey);

                AppendTextToLog(string.Format("NO.{0:00000}: {1:0000000000} | Key:{2:00000}\r\n", i + 1, cryptKey, bxv));

                pBar.Value += 1;
                Application.DoEvents();
                if (lbxv != bxv)
                {
                    lbxv = bxv;
                    continue;
                }
                if (lbxv == bxv)
                {
                    // 失败
                    bIsPassed = false;
                    if (i >= 999)
                    {
                        pBar.Maximum = 1000;
                        break;
                    }
                }
            }

            AppendTextToLog(string.Format("=============================="));

            if (bIsPassed)
            {
                // 成功
                lbResult.Text = "通过，可以防住封包重发器";
                lbResult.ForeColor = Color.Green;
                MessageBox.Show(this, "通过，可以防住封包重发器。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 失败
                lbResult.Text = "失败，无法防住封包重发器";
                lbResult.ForeColor = Color.Red;
                MessageBox.Show(this, "失败，无法防住封包重发器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnStressTest.Enabled = true;
        }

    }
}
