namespace SerialPort_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portNamesCombobox = new System.Windows.Forms.ComboBox();
            this.baudRateCombobox = new System.Windows.Forms.ComboBox();
            this.dataBitsCombobox = new System.Windows.Forms.ComboBox();
            this.stopBitsCombobox = new System.Windows.Forms.ComboBox();
            this.parityCombobox = new System.Windows.Forms.ComboBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.autoSendCycleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AutoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearReceiveButton = new System.Windows.Forms.Button();
            this.hexadecimalDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClearCheckBox = new System.Windows.Forms.CheckBox();
            this.turnOnButton = new System.Windows.Forms.CheckBox();
            this.stopShowingButton = new System.Windows.Forms.CheckBox();
            this.hexadecimalSendCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearSendButton = new System.Windows.Forms.Button();
            this.statusTextBlock = new System.Windows.Forms.TextBox();
            this.statusReceiveByteTextBlock = new System.Windows.Forms.TextBox();
            this.statusSendByteTextBlock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.countClearButton = new System.Windows.Forms.Button();
            this.autoDetectionTimer = new System.Windows.Forms.Timer(this.components);
            this.autoSendTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "奇偶校验";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "波特率";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "数据位";
            // 
            // portNamesCombobox
            // 
            this.portNamesCombobox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portNamesCombobox.FormattingEnabled = true;
            this.portNamesCombobox.Location = new System.Drawing.Point(78, 16);
            this.portNamesCombobox.Name = "portNamesCombobox";
            this.portNamesCombobox.Size = new System.Drawing.Size(99, 28);
            this.portNamesCombobox.TabIndex = 5;
            // 
            // baudRateCombobox
            // 
            this.baudRateCombobox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.baudRateCombobox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baudRateCombobox.FormattingEnabled = true;
            this.baudRateCombobox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000",
            "460800",
            "921600"});
            this.baudRateCombobox.Location = new System.Drawing.Point(78, 63);
            this.baudRateCombobox.Name = "baudRateCombobox";
            this.baudRateCombobox.Size = new System.Drawing.Size(99, 28);
            this.baudRateCombobox.TabIndex = 6;
            // 
            // dataBitsCombobox
            // 
            this.dataBitsCombobox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataBitsCombobox.FormattingEnabled = true;
            this.dataBitsCombobox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitsCombobox.Location = new System.Drawing.Point(78, 157);
            this.dataBitsCombobox.Name = "dataBitsCombobox";
            this.dataBitsCombobox.Size = new System.Drawing.Size(99, 28);
            this.dataBitsCombobox.TabIndex = 13;
            this.dataBitsCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox_byte_size_SelectedIndexChanged);
            // 
            // stopBitsCombobox
            // 
            this.stopBitsCombobox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopBitsCombobox.FormattingEnabled = true;
            this.stopBitsCombobox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitsCombobox.Location = new System.Drawing.Point(78, 204);
            this.stopBitsCombobox.Name = "stopBitsCombobox";
            this.stopBitsCombobox.Size = new System.Drawing.Size(99, 28);
            this.stopBitsCombobox.TabIndex = 14;
            // 
            // parityCombobox
            // 
            this.parityCombobox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parityCombobox.FormattingEnabled = true;
            this.parityCombobox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityCombobox.Location = new System.Drawing.Point(78, 110);
            this.parityCombobox.Name = "parityCombobox";
            this.parityCombobox.Size = new System.Drawing.Size(99, 28);
            this.parityCombobox.TabIndex = 15;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(409, 374);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(649, 135);
            this.sendTextBox.TabIndex = 22;
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiveTextBox.Location = new System.Drawing.Point(409, 23);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.ReadOnly = true;
            this.receiveTextBox.Size = new System.Drawing.Size(649, 312);
            this.receiveTextBox.TabIndex = 23;
            this.receiveTextBox.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(294, 428);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(83, 47);
            this.SendButton.TabIndex = 31;
            this.SendButton.Text = "手动发送";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "毫秒";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // autoSendCycleTextBox
            // 
            this.autoSendCycleTextBox.Location = new System.Drawing.Point(137, 314);
            this.autoSendCycleTextBox.Name = "autoSendCycleTextBox";
            this.autoSendCycleTextBox.Size = new System.Drawing.Size(60, 21);
            this.autoSendCycleTextBox.TabIndex = 29;
            this.autoSendCycleTextBox.Text = "1000";
            this.autoSendCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "自动发送周期";
            // 
            // AutoSendCheckBox
            // 
            this.AutoSendCheckBox.AutoSize = true;
            this.AutoSendCheckBox.Location = new System.Drawing.Point(37, 376);
            this.AutoSendCheckBox.Name = "AutoSendCheckBox";
            this.AutoSendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoSendCheckBox.TabIndex = 27;
            this.AutoSendCheckBox.Text = "自动发送";
            this.AutoSendCheckBox.UseVisualStyleBackColor = true;
            this.AutoSendCheckBox.CheckedChanged += new System.EventHandler(this.cbTimeSend_CheckedChanged);
            // 
            // ClearReceiveButton
            // 
            this.ClearReceiveButton.Location = new System.Drawing.Point(314, 70);
            this.ClearReceiveButton.Name = "ClearReceiveButton";
            this.ClearReceiveButton.Size = new System.Drawing.Size(63, 22);
            this.ClearReceiveButton.TabIndex = 32;
            this.ClearReceiveButton.Text = "清空接收区";
            this.ClearReceiveButton.UseVisualStyleBackColor = true;
            // 
            // hexadecimalDisplayCheckBox
            // 
            this.hexadecimalDisplayCheckBox.AutoSize = true;
            this.hexadecimalDisplayCheckBox.Location = new System.Drawing.Point(200, 117);
            this.hexadecimalDisplayCheckBox.Name = "hexadecimalDisplayCheckBox";
            this.hexadecimalDisplayCheckBox.Size = new System.Drawing.Size(96, 16);
            this.hexadecimalDisplayCheckBox.TabIndex = 34;
            this.hexadecimalDisplayCheckBox.Text = "十六进制显示";
            this.hexadecimalDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearCheckBox
            // 
            this.autoClearCheckBox.AutoSize = true;
            this.autoClearCheckBox.Location = new System.Drawing.Point(200, 70);
            this.autoClearCheckBox.Name = "autoClearCheckBox";
            this.autoClearCheckBox.Size = new System.Drawing.Size(72, 16);
            this.autoClearCheckBox.TabIndex = 35;
            this.autoClearCheckBox.Text = "自动清空";
            this.autoClearCheckBox.UseVisualStyleBackColor = true;
            // 
            // turnOnButton
            // 
            this.turnOnButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.turnOnButton.AutoSize = true;
            this.turnOnButton.Location = new System.Drawing.Point(246, 182);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(63, 22);
            this.turnOnButton.TabIndex = 36;
            this.turnOnButton.Text = "打开串口";
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.CheckedChanged += new System.EventHandler(this.turnOnButton_CheckedChanged);
            // 
            // stopShowingButton
            // 
            this.stopShowingButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.stopShowingButton.AutoSize = true;
            this.stopShowingButton.Location = new System.Drawing.Point(314, 112);
            this.stopShowingButton.Name = "stopShowingButton";
            this.stopShowingButton.Size = new System.Drawing.Size(63, 22);
            this.stopShowingButton.TabIndex = 37;
            this.stopShowingButton.Text = "停止显示";
            this.stopShowingButton.UseVisualStyleBackColor = true;
            // 
            // hexadecimalSendCheckBox
            // 
            this.hexadecimalSendCheckBox.AutoSize = true;
            this.hexadecimalSendCheckBox.Location = new System.Drawing.Point(159, 376);
            this.hexadecimalSendCheckBox.Name = "hexadecimalSendCheckBox";
            this.hexadecimalSendCheckBox.Size = new System.Drawing.Size(96, 16);
            this.hexadecimalSendCheckBox.TabIndex = 38;
            this.hexadecimalSendCheckBox.Text = "十六进制发送";
            this.hexadecimalSendCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearSendButton
            // 
            this.ClearSendButton.Location = new System.Drawing.Point(40, 428);
            this.ClearSendButton.Name = "ClearSendButton";
            this.ClearSendButton.Size = new System.Drawing.Size(83, 47);
            this.ClearSendButton.TabIndex = 39;
            this.ClearSendButton.Text = "清空重填";
            this.ClearSendButton.UseVisualStyleBackColor = true;
            // 
            // statusTextBlock
            // 
            this.statusTextBlock.BackColor = System.Drawing.SystemColors.Info;
            this.statusTextBlock.Location = new System.Drawing.Point(20, 518);
            this.statusTextBlock.Name = "statusTextBlock";
            this.statusTextBlock.ReadOnly = true;
            this.statusTextBlock.Size = new System.Drawing.Size(115, 21);
            this.statusTextBlock.TabIndex = 40;
            this.statusTextBlock.Text = "准备就绪";
            this.statusTextBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusReceiveByteTextBlock
            // 
            this.statusReceiveByteTextBlock.Location = new System.Drawing.Point(494, 518);
            this.statusReceiveByteTextBlock.Name = "statusReceiveByteTextBlock";
            this.statusReceiveByteTextBlock.Size = new System.Drawing.Size(109, 21);
            this.statusReceiveByteTextBlock.TabIndex = 41;
            // 
            // statusSendByteTextBlock
            // 
            this.statusSendByteTextBlock.Location = new System.Drawing.Point(738, 524);
            this.statusSendByteTextBlock.Name = "statusSendByteTextBlock";
            this.statusSendByteTextBlock.Size = new System.Drawing.Size(107, 21);
            this.statusSendByteTextBlock.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "发送字节数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "接收字节数";
            // 
            // countClearButton
            // 
            this.countClearButton.Location = new System.Drawing.Point(955, 518);
            this.countClearButton.Name = "countClearButton";
            this.countClearButton.Size = new System.Drawing.Size(75, 23);
            this.countClearButton.TabIndex = 45;
            this.countClearButton.Text = "计数清零";
            this.countClearButton.UseVisualStyleBackColor = true;
            // 
            // autoDetectionTimer
            // 
            this.autoDetectionTimer.Tick += new System.EventHandler(this.AutoDectionTimer_Tick);
            // 
            // autoSendTimer
            // 
            this.autoSendTimer.Interval = 1000;
            this.autoSendTimer.Tick += new System.EventHandler(this.AutoSendTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 629);
            this.Controls.Add(this.countClearButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusSendByteTextBlock);
            this.Controls.Add(this.statusReceiveByteTextBlock);
            this.Controls.Add(this.statusTextBlock);
            this.Controls.Add(this.ClearSendButton);
            this.Controls.Add(this.hexadecimalSendCheckBox);
            this.Controls.Add(this.stopShowingButton);
            this.Controls.Add(this.turnOnButton);
            this.Controls.Add(this.autoClearCheckBox);
            this.Controls.Add(this.hexadecimalDisplayCheckBox);
            this.Controls.Add(this.ClearReceiveButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.autoSendCycleTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AutoSendCheckBox);
            this.Controls.Add(this.receiveTextBox);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.parityCombobox);
            this.Controls.Add(this.stopBitsCombobox);
            this.Controls.Add(this.dataBitsCombobox);
            this.Controls.Add(this.baudRateCombobox);
            this.Controls.Add(this.portNamesCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox portNamesCombobox;
        private System.Windows.Forms.ComboBox baudRateCombobox;
        private System.Windows.Forms.ComboBox dataBitsCombobox;
        private System.Windows.Forms.ComboBox stopBitsCombobox;
        private System.Windows.Forms.ComboBox parityCombobox;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.RichTextBox receiveTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox autoSendCycleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox AutoSendCheckBox;
        private System.Windows.Forms.Button ClearReceiveButton;
        private System.Windows.Forms.CheckBox hexadecimalDisplayCheckBox;
        private System.Windows.Forms.CheckBox autoClearCheckBox;
        private System.Windows.Forms.CheckBox turnOnButton;
        private System.Windows.Forms.CheckBox stopShowingButton;
        private System.Windows.Forms.CheckBox hexadecimalSendCheckBox;
        private System.Windows.Forms.Button ClearSendButton;
        private System.Windows.Forms.TextBox statusTextBlock;
        private System.Windows.Forms.TextBox statusReceiveByteTextBlock;
        private System.Windows.Forms.TextBox statusSendByteTextBlock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button countClearButton;
        private System.Windows.Forms.Timer autoDetectionTimer;
        private System.Windows.Forms.Timer autoSendTimer;
    }
}

