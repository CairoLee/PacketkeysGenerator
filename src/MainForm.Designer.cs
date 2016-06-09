namespace PacketkeysGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStressLog = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeneric = new System.Windows.Forms.Button();
            this.cbCreateLastSameKey = new System.Windows.Forms.CheckBox();
            this.txtGenericPacketKeyGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenericThirdKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenericSecondKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenericFirstKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnStressTest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStressThirdKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStressSecondKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStressFirstKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResult);
            this.groupBox1.Controls.Add(this.txtStressLog);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(263, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "暴力测算结果";
            // 
            // txtStressLog
            // 
            this.txtStressLog.Location = new System.Drawing.Point(14, 20);
            this.txtStressLog.Multiline = true;
            this.txtStressLog.Name = "txtStressLog";
            this.txtStressLog.ReadOnly = true;
            this.txtStressLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStressLog.Size = new System.Drawing.Size(208, 282);
            this.txtStressLog.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "测算结果：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeneric);
            this.groupBox2.Controls.Add(this.cbCreateLastSameKey);
            this.groupBox2.Controls.Add(this.txtGenericPacketKeyGroup);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGenericThirdKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtGenericSecondKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGenericFirstKey);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "高强度密钥生成";
            // 
            // btnGeneric
            // 
            this.btnGeneric.Location = new System.Drawing.Point(10, 131);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(222, 35);
            this.btnGeneric.TabIndex = 9;
            this.btnGeneric.Text = "生成强力密钥";
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // cbCreateLastSameKey
            // 
            this.cbCreateLastSameKey.AutoSize = true;
            this.cbCreateLastSameKey.Location = new System.Drawing.Point(10, 107);
            this.cbCreateLastSameKey.Name = "cbCreateLastSameKey";
            this.cbCreateLastSameKey.Size = new System.Drawing.Size(230, 17);
            this.cbCreateLastSameKey.TabIndex = 8;
            this.cbCreateLastSameKey.Text = "生成第二和第三个密钥一致的强力密钥";
            this.cbCreateLastSameKey.UseVisualStyleBackColor = true;
            // 
            // txtGenericPacketKeyGroup
            // 
            this.txtGenericPacketKeyGroup.Location = new System.Drawing.Point(10, 80);
            this.txtGenericPacketKeyGroup.Name = "txtGenericPacketKeyGroup";
            this.txtGenericPacketKeyGroup.Size = new System.Drawing.Size(222, 20);
            this.txtGenericPacketKeyGroup.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "拼接结果（方便复制到 packet_db,txt）：";
            // 
            // txtGenericThirdKey
            // 
            this.txtGenericThirdKey.Location = new System.Drawing.Point(162, 37);
            this.txtGenericThirdKey.Name = "txtGenericThirdKey";
            this.txtGenericThirdKey.Size = new System.Drawing.Size(70, 20);
            this.txtGenericThirdKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "第三个：";
            // 
            // txtGenericSecondKey
            // 
            this.txtGenericSecondKey.Location = new System.Drawing.Point(86, 37);
            this.txtGenericSecondKey.Name = "txtGenericSecondKey";
            this.txtGenericSecondKey.Size = new System.Drawing.Size(70, 20);
            this.txtGenericSecondKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "第二个：";
            // 
            // txtGenericFirstKey
            // 
            this.txtGenericFirstKey.Location = new System.Drawing.Point(10, 37);
            this.txtGenericFirstKey.Name = "txtGenericFirstKey";
            this.txtGenericFirstKey.Size = new System.Drawing.Size(70, 20);
            this.txtGenericFirstKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一个：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pBar);
            this.groupBox3.Controls.Add(this.btnStressTest);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtStressThirdKey);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtStressSecondKey);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtStressFirstKey);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "暴力测算";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(10, 80);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(222, 15);
            this.pBar.TabIndex = 10;
            // 
            // btnStressTest
            // 
            this.btnStressTest.Location = new System.Drawing.Point(10, 103);
            this.btnStressTest.Name = "btnStressTest";
            this.btnStressTest.Size = new System.Drawing.Size(222, 35);
            this.btnStressTest.TabIndex = 9;
            this.btnStressTest.Text = "进行暴力测算";
            this.btnStressTest.UseVisualStyleBackColor = true;
            this.btnStressTest.Click += new System.EventHandler(this.btnStressTest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "暴力测算进度：";
            // 
            // txtStressThirdKey
            // 
            this.txtStressThirdKey.Location = new System.Drawing.Point(162, 37);
            this.txtStressThirdKey.Name = "txtStressThirdKey";
            this.txtStressThirdKey.Size = new System.Drawing.Size(70, 20);
            this.txtStressThirdKey.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "第三个：";
            // 
            // txtStressSecondKey
            // 
            this.txtStressSecondKey.Location = new System.Drawing.Point(86, 37);
            this.txtStressSecondKey.Name = "txtStressSecondKey";
            this.txtStressSecondKey.Size = new System.Drawing.Size(70, 20);
            this.txtStressSecondKey.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "第二个：";
            // 
            // txtStressFirstKey
            // 
            this.txtStressFirstKey.Location = new System.Drawing.Point(10, 37);
            this.txtStressFirstKey.Name = "txtStressFirstKey";
            this.txtStressFirstKey.Size = new System.Drawing.Size(70, 20);
            this.txtStressFirstKey.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "第一个：";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(74, 313);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(127, 13);
            this.lbResult.TabIndex = 9;
            this.lbResult.Text = "测算结果将显示在这里";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 363);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packetkeys Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGeneric;
        private System.Windows.Forms.CheckBox cbCreateLastSameKey;
        private System.Windows.Forms.TextBox txtGenericPacketKeyGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenericThirdKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenericSecondKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenericFirstKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnStressTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStressThirdKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStressSecondKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStressFirstKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStressLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbResult;
    }
}

