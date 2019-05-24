namespace UartApp
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.StopBit = new System.Windows.Forms.ComboBox();
            this.CheckBit = new System.Windows.Forms.ComboBox();
            this.DataBit = new System.Windows.Forms.ComboBox();
            this.BaundRate = new System.Windows.Forms.ComboBox();
            this.PortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RecBuff = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SndBuff = new System.Windows.Forms.TextBox();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RecASCII = new System.Windows.Forms.RadioButton();
            this.RecHEX = new System.Windows.Forms.RadioButton();
            this.ShowRecTime = new System.Windows.Forms.CheckBox();
            this.btnClearRecBuff = new System.Windows.Forms.Button();
            this.SndHEX = new System.Windows.Forms.RadioButton();
            this.SndASCII = new System.Windows.Forms.RadioButton();
            this.SndNewLine = new System.Windows.Forms.CheckBox();
            this.AutoSend = new System.Windows.Forms.CheckBox();
            this.AutoSendDelay = new System.Windows.Forms.NumericUpDown();
            this.Message = new System.Windows.Forms.TextBox();
            this.TxCountShow = new System.Windows.Forms.TextBox();
            this.RxCountShow = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoSendDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOpenPort);
            this.panel1.Controls.Add(this.StopBit);
            this.panel1.Controls.Add(this.CheckBit);
            this.panel1.Controls.Add(this.DataBit);
            this.panel1.Controls.Add(this.BaundRate);
            this.panel1.Controls.Add(this.PortName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 189);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(9, 150);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(134, 27);
            this.btnOpenPort.TabIndex = 10;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.BtnOpenPort_Click);
            // 
            // StopBit
            // 
            this.StopBit.FormattingEnabled = true;
            this.StopBit.Location = new System.Drawing.Point(55, 116);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(88, 21);
            this.StopBit.TabIndex = 9;
            // 
            // CheckBit
            // 
            this.CheckBit.FormattingEnabled = true;
            this.CheckBit.Location = new System.Drawing.Point(55, 89);
            this.CheckBit.Name = "CheckBit";
            this.CheckBit.Size = new System.Drawing.Size(88, 21);
            this.CheckBit.TabIndex = 8;
            // 
            // DataBit
            // 
            this.DataBit.FormattingEnabled = true;
            this.DataBit.Location = new System.Drawing.Point(55, 62);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(88, 21);
            this.DataBit.TabIndex = 7;
            // 
            // BaundRate
            // 
            this.BaundRate.FormattingEnabled = true;
            this.BaundRate.Location = new System.Drawing.Point(55, 35);
            this.BaundRate.Name = "BaundRate";
            this.BaundRate.Size = new System.Drawing.Size(88, 21);
            this.BaundRate.TabIndex = 6;
            // 
            // PortName
            // 
            this.PortName.FormattingEnabled = true;
            this.PortName.Location = new System.Drawing.Point(55, 8);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(88, 21);
            this.PortName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "串    口";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClearRecBuff);
            this.panel2.Controls.Add(this.ShowRecTime);
            this.panel2.Controls.Add(this.RecHEX);
            this.panel2.Controls.Add(this.RecASCII);
            this.panel2.Location = new System.Drawing.Point(12, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 134);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AutoSendDelay);
            this.panel3.Controls.Add(this.AutoSend);
            this.panel3.Controls.Add(this.SndNewLine);
            this.panel3.Controls.Add(this.SndHEX);
            this.panel3.Controls.Add(this.SndASCII);
            this.panel3.Location = new System.Drawing.Point(12, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 77);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RxCountShow);
            this.panel4.Controls.Add(this.TxCountShow);
            this.panel4.Controls.Add(this.Message);
            this.panel4.Location = new System.Drawing.Point(12, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 44);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.RecBuff);
            this.panel5.Location = new System.Drawing.Point(182, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(613, 333);
            this.panel5.TabIndex = 4;
            // 
            // RecBuff
            // 
            this.RecBuff.Location = new System.Drawing.Point(3, 3);
            this.RecBuff.Multiline = true;
            this.RecBuff.Name = "RecBuff";
            this.RecBuff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecBuff.Size = new System.Drawing.Size(603, 325);
            this.RecBuff.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.BtnSend);
            this.panel6.Controls.Add(this.SndBuff);
            this.panel6.Location = new System.Drawing.Point(182, 351);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(613, 77);
            this.panel6.TabIndex = 5;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(546, 3);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(60, 64);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "发送";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // SndBuff
            // 
            this.SndBuff.Location = new System.Drawing.Point(3, 3);
            this.SndBuff.Multiline = true;
            this.SndBuff.Name = "SndBuff";
            this.SndBuff.Size = new System.Drawing.Size(537, 64);
            this.SndBuff.TabIndex = 0;
            // 
            // sp
            // 
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // RecASCII
            // 
            this.RecASCII.AutoSize = true;
            this.RecASCII.Checked = true;
            this.RecASCII.Location = new System.Drawing.Point(9, 13);
            this.RecASCII.Name = "RecASCII";
            this.RecASCII.Size = new System.Drawing.Size(52, 17);
            this.RecASCII.TabIndex = 0;
            this.RecASCII.TabStop = true;
            this.RecASCII.Text = "ASCII";
            this.RecASCII.UseVisualStyleBackColor = true;
            // 
            // RecHEX
            // 
            this.RecHEX.AutoSize = true;
            this.RecHEX.Location = new System.Drawing.Point(91, 13);
            this.RecHEX.Name = "RecHEX";
            this.RecHEX.Size = new System.Drawing.Size(47, 17);
            this.RecHEX.TabIndex = 1;
            this.RecHEX.Text = "HEX";
            this.RecHEX.UseVisualStyleBackColor = true;
            this.RecHEX.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // ShowRecTime
            // 
            this.ShowRecTime.AutoSize = true;
            this.ShowRecTime.Location = new System.Drawing.Point(9, 35);
            this.ShowRecTime.Name = "ShowRecTime";
            this.ShowRecTime.Size = new System.Drawing.Size(122, 17);
            this.ShowRecTime.TabIndex = 2;
            this.ShowRecTime.Text = "显示数据接收时间";
            this.ShowRecTime.UseVisualStyleBackColor = true;
            // 
            // btnClearRecBuff
            // 
            this.btnClearRecBuff.Location = new System.Drawing.Point(9, 57);
            this.btnClearRecBuff.Name = "btnClearRecBuff";
            this.btnClearRecBuff.Size = new System.Drawing.Size(134, 25);
            this.btnClearRecBuff.TabIndex = 3;
            this.btnClearRecBuff.Text = "清空接收区";
            this.btnClearRecBuff.UseVisualStyleBackColor = true;
            this.btnClearRecBuff.Click += new System.EventHandler(this.BtnClearRecBuff_Click);
            // 
            // SndHEX
            // 
            this.SndHEX.AutoSize = true;
            this.SndHEX.Location = new System.Drawing.Point(91, 4);
            this.SndHEX.Name = "SndHEX";
            this.SndHEX.Size = new System.Drawing.Size(47, 17);
            this.SndHEX.TabIndex = 3;
            this.SndHEX.Text = "HEX";
            this.SndHEX.UseVisualStyleBackColor = true;
            // 
            // SndASCII
            // 
            this.SndASCII.AutoSize = true;
            this.SndASCII.Checked = true;
            this.SndASCII.Location = new System.Drawing.Point(9, 4);
            this.SndASCII.Name = "SndASCII";
            this.SndASCII.Size = new System.Drawing.Size(52, 17);
            this.SndASCII.TabIndex = 2;
            this.SndASCII.TabStop = true;
            this.SndASCII.Text = "ASCII";
            this.SndASCII.UseVisualStyleBackColor = true;
            // 
            // SndNewLine
            // 
            this.SndNewLine.AutoSize = true;
            this.SndNewLine.Location = new System.Drawing.Point(9, 27);
            this.SndNewLine.Name = "SndNewLine";
            this.SndNewLine.Size = new System.Drawing.Size(74, 17);
            this.SndNewLine.TabIndex = 4;
            this.SndNewLine.Text = "发送新行";
            this.SndNewLine.UseVisualStyleBackColor = true;
            // 
            // AutoSend
            // 
            this.AutoSend.AutoSize = true;
            this.AutoSend.Location = new System.Drawing.Point(9, 50);
            this.AutoSend.Name = "AutoSend";
            this.AutoSend.Size = new System.Drawing.Size(74, 17);
            this.AutoSend.TabIndex = 5;
            this.AutoSend.Text = "自动发送";
            this.AutoSend.UseVisualStyleBackColor = true;
            // 
            // AutoSendDelay
            // 
            this.AutoSendDelay.Location = new System.Drawing.Point(89, 47);
            this.AutoSendDelay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.AutoSendDelay.Name = "AutoSendDelay";
            this.AutoSendDelay.Size = new System.Drawing.Size(60, 20);
            this.AutoSendDelay.TabIndex = 6;
            this.AutoSendDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Message
            // 
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Location = new System.Drawing.Point(6, 6);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(312, 13);
            this.Message.TabIndex = 0;
            // 
            // TxCountShow
            // 
            this.TxCountShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxCountShow.Location = new System.Drawing.Point(324, 6);
            this.TxCountShow.Name = "TxCountShow";
            this.TxCountShow.Size = new System.Drawing.Size(101, 13);
            this.TxCountShow.TabIndex = 1;
            this.TxCountShow.Text = "TX: 0 Bytes";
            // 
            // RxCountShow
            // 
            this.RxCountShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RxCountShow.Location = new System.Drawing.Point(431, 6);
            this.RxCountShow.Name = "RxCountShow";
            this.RxCountShow.Size = new System.Drawing.Size(100, 13);
            this.RxCountShow.TabIndex = 2;
            this.RxCountShow.Text = "RX: 0 Bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoSendDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StopBit;
        private System.Windows.Forms.ComboBox CheckBit;
        private System.Windows.Forms.ComboBox DataBit;
        private System.Windows.Forms.ComboBox BaundRate;
        private System.Windows.Forms.ComboBox PortName;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.TextBox RecBuff;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox SndBuff;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton RecHEX;
        private System.Windows.Forms.RadioButton RecASCII;
        private System.Windows.Forms.CheckBox ShowRecTime;
        private System.Windows.Forms.Button btnClearRecBuff;
        private System.Windows.Forms.RadioButton SndHEX;
        private System.Windows.Forms.RadioButton SndASCII;
        private System.Windows.Forms.NumericUpDown AutoSendDelay;
        private System.Windows.Forms.CheckBox AutoSend;
        private System.Windows.Forms.CheckBox SndNewLine;
        private System.Windows.Forms.TextBox RxCountShow;
        private System.Windows.Forms.TextBox TxCountShow;
        private System.Windows.Forms.TextBox Message;
    }
}

