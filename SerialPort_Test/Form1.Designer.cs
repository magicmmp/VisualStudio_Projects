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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton485 = new System.Windows.Forms.RadioButton();
            this.radioButtonLora = new System.Windows.Forms.RadioButton();
            this.radioButtonPort = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLoraAddr = new System.Windows.Forms.TextBox();
            this.checkBoxAutoAddr = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "奇偶校验";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "波特率";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "数据位";
            // 
            // portNamesCombobox
            // 
            this.portNamesCombobox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portNamesCombobox.FormattingEnabled = true;
            this.portNamesCombobox.Location = new System.Drawing.Point(104, 20);
            this.portNamesCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portNamesCombobox.Name = "portNamesCombobox";
            this.portNamesCombobox.Size = new System.Drawing.Size(131, 33);
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
            this.baudRateCombobox.Location = new System.Drawing.Point(104, 79);
            this.baudRateCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baudRateCombobox.Name = "baudRateCombobox";
            this.baudRateCombobox.Size = new System.Drawing.Size(131, 33);
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
            this.dataBitsCombobox.Location = new System.Drawing.Point(104, 196);
            this.dataBitsCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataBitsCombobox.Name = "dataBitsCombobox";
            this.dataBitsCombobox.Size = new System.Drawing.Size(131, 33);
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
            this.stopBitsCombobox.Location = new System.Drawing.Point(104, 255);
            this.stopBitsCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopBitsCombobox.Name = "stopBitsCombobox";
            this.stopBitsCombobox.Size = new System.Drawing.Size(131, 33);
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
            this.parityCombobox.Location = new System.Drawing.Point(104, 138);
            this.parityCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parityCombobox.Name = "parityCombobox";
            this.parityCombobox.Size = new System.Drawing.Size(131, 33);
            this.parityCombobox.TabIndex = 15;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sendTextBox.Location = new System.Drawing.Point(545, 449);
            this.sendTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendTextBox.MinimumSize = new System.Drawing.Size(864, 168);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(876, 269);
            this.sendTextBox.TabIndex = 22;
            this.sendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendTextBox_KeyPress);
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.receiveTextBox.Location = new System.Drawing.Point(545, 21);
            this.receiveTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receiveTextBox.MinimumSize = new System.Drawing.Size(864, 389);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.ReadOnly = true;
            this.receiveTextBox.Size = new System.Drawing.Size(876, 389);
            this.receiveTextBox.TabIndex = 23;
            this.receiveTextBox.Text = "";
            this.receiveTextBox.TextChanged += new System.EventHandler(this.receiveTextBox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(364, 638);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(111, 59);
            this.SendButton.TabIndex = 31;
            this.SendButton.Text = "手动发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 534);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "毫秒";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // autoSendCycleTextBox
            // 
            this.autoSendCycleTextBox.Location = new System.Drawing.Point(156, 534);
            this.autoSendCycleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoSendCycleTextBox.MaxLength = 6;
            this.autoSendCycleTextBox.Name = "autoSendCycleTextBox";
            this.autoSendCycleTextBox.Size = new System.Drawing.Size(79, 25);
            this.autoSendCycleTextBox.TabIndex = 29;
            this.autoSendCycleTextBox.Text = "1000";
            this.autoSendCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.autoSendCycleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.autoSendCycleTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 534);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "自动发送周期";
            // 
            // AutoSendCheckBox
            // 
            this.AutoSendCheckBox.AutoSize = true;
            this.AutoSendCheckBox.Location = new System.Drawing.Point(23, 585);
            this.AutoSendCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoSendCheckBox.Name = "AutoSendCheckBox";
            this.AutoSendCheckBox.Size = new System.Drawing.Size(89, 19);
            this.AutoSendCheckBox.TabIndex = 27;
            this.AutoSendCheckBox.Text = "自动发送";
            this.AutoSendCheckBox.UseVisualStyleBackColor = true;
            this.AutoSendCheckBox.CheckedChanged += new System.EventHandler(this.AutoSendCheckBox_CheckedChanged);
            this.AutoSendCheckBox.CheckStateChanged += new System.EventHandler(this.AutoSendCheckBox_CheckStateChanged);
            // 
            // ClearReceiveButton
            // 
            this.ClearReceiveButton.Location = new System.Drawing.Point(419, 88);
            this.ClearReceiveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearReceiveButton.Name = "ClearReceiveButton";
            this.ClearReceiveButton.Size = new System.Drawing.Size(84, 28);
            this.ClearReceiveButton.TabIndex = 32;
            this.ClearReceiveButton.Text = "清空接收区";
            this.ClearReceiveButton.UseVisualStyleBackColor = true;
            this.ClearReceiveButton.Click += new System.EventHandler(this.ClearReceiveButton_Click);
            // 
            // hexadecimalDisplayCheckBox
            // 
            this.hexadecimalDisplayCheckBox.AutoSize = true;
            this.hexadecimalDisplayCheckBox.Location = new System.Drawing.Point(267, 146);
            this.hexadecimalDisplayCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hexadecimalDisplayCheckBox.Name = "hexadecimalDisplayCheckBox";
            this.hexadecimalDisplayCheckBox.Size = new System.Drawing.Size(119, 19);
            this.hexadecimalDisplayCheckBox.TabIndex = 34;
            this.hexadecimalDisplayCheckBox.Text = "十六进制显示";
            this.hexadecimalDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearCheckBox
            // 
            this.autoClearCheckBox.AutoSize = true;
            this.autoClearCheckBox.Location = new System.Drawing.Point(267, 88);
            this.autoClearCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoClearCheckBox.Name = "autoClearCheckBox";
            this.autoClearCheckBox.Size = new System.Drawing.Size(89, 19);
            this.autoClearCheckBox.TabIndex = 35;
            this.autoClearCheckBox.Text = "自动清空";
            this.autoClearCheckBox.UseVisualStyleBackColor = true;
            // 
            // turnOnButton
            // 
            this.turnOnButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.turnOnButton.AutoSize = true;
            this.turnOnButton.Location = new System.Drawing.Point(328, 228);
            this.turnOnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(77, 25);
            this.turnOnButton.TabIndex = 36;
            this.turnOnButton.Text = "打开串口";
            this.turnOnButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.CheckedChanged += new System.EventHandler(this.turnOnButton_CheckedChanged);
            // 
            // stopShowingButton
            // 
            this.stopShowingButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.stopShowingButton.AutoSize = true;
            this.stopShowingButton.Location = new System.Drawing.Point(419, 140);
            this.stopShowingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopShowingButton.Name = "stopShowingButton";
            this.stopShowingButton.Size = new System.Drawing.Size(77, 25);
            this.stopShowingButton.TabIndex = 37;
            this.stopShowingButton.Text = "停止显示";
            this.stopShowingButton.UseVisualStyleBackColor = true;
            this.stopShowingButton.CheckedChanged += new System.EventHandler(this.stopShowingButton_CheckedChanged);
            // 
            // hexadecimalSendCheckBox
            // 
            this.hexadecimalSendCheckBox.AutoSize = true;
            this.hexadecimalSendCheckBox.Location = new System.Drawing.Point(188, 585);
            this.hexadecimalSendCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hexadecimalSendCheckBox.Name = "hexadecimalSendCheckBox";
            this.hexadecimalSendCheckBox.Size = new System.Drawing.Size(119, 19);
            this.hexadecimalSendCheckBox.TabIndex = 38;
            this.hexadecimalSendCheckBox.Text = "十六进制发送";
            this.hexadecimalSendCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearSendButton
            // 
            this.ClearSendButton.Location = new System.Drawing.Point(35, 638);
            this.ClearSendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearSendButton.Name = "ClearSendButton";
            this.ClearSendButton.Size = new System.Drawing.Size(111, 59);
            this.ClearSendButton.TabIndex = 39;
            this.ClearSendButton.Text = "清空重填";
            this.ClearSendButton.UseVisualStyleBackColor = true;
            this.ClearSendButton.Click += new System.EventHandler(this.ClearSendButton_Click);
            // 
            // statusTextBlock
            // 
            this.statusTextBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.statusTextBlock.Location = new System.Drawing.Point(35, 741);
            this.statusTextBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusTextBlock.Name = "statusTextBlock";
            this.statusTextBlock.ReadOnly = true;
            this.statusTextBlock.Size = new System.Drawing.Size(152, 25);
            this.statusTextBlock.TabIndex = 40;
            this.statusTextBlock.Text = "准备就绪";
            this.statusTextBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusReceiveByteTextBlock
            // 
            this.statusReceiveByteTextBlock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusReceiveByteTextBlock.Location = new System.Drawing.Point(756, 741);
            this.statusReceiveByteTextBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusReceiveByteTextBlock.Name = "statusReceiveByteTextBlock";
            this.statusReceiveByteTextBlock.Size = new System.Drawing.Size(144, 25);
            this.statusReceiveByteTextBlock.TabIndex = 41;
            // 
            // statusSendByteTextBlock
            // 
            this.statusSendByteTextBlock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusSendByteTextBlock.Location = new System.Drawing.Point(1101, 741);
            this.statusSendByteTextBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusSendByteTextBlock.Name = "statusSendByteTextBlock";
            this.statusSendByteTextBlock.Size = new System.Drawing.Size(141, 25);
            this.statusSendByteTextBlock.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(968, 745);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "发送字节数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 745);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "接收字节数";
            // 
            // countClearButton
            // 
            this.countClearButton.Location = new System.Drawing.Point(1319, 741);
            this.countClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countClearButton.Name = "countClearButton";
            this.countClearButton.Size = new System.Drawing.Size(100, 29);
            this.countClearButton.TabIndex = 45;
            this.countClearButton.Text = "计数清零";
            this.countClearButton.UseVisualStyleBackColor = true;
            this.countClearButton.Click += new System.EventHandler(this.countClearButton_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.radioButton485);
            this.groupBox1.Controls.Add(this.radioButtonLora);
            this.groupBox1.Controls.Add(this.radioButtonPort);
            this.groupBox1.Location = new System.Drawing.Point(19, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(149, 190);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用途";
            // 
            // radioButton485
            // 
            this.radioButton485.AutoSize = true;
            this.radioButton485.Location = new System.Drawing.Point(16, 134);
            this.radioButton485.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton485.Name = "radioButton485";
            this.radioButton485.Size = new System.Drawing.Size(82, 19);
            this.radioButton485.TabIndex = 2;
            this.radioButton485.Text = "485测试";
            this.radioButton485.UseVisualStyleBackColor = true;
            this.radioButton485.CheckedChanged += new System.EventHandler(this.radioButton485_CheckedChanged);
            // 
            // radioButtonLora
            // 
            this.radioButtonLora.AutoSize = true;
            this.radioButtonLora.Location = new System.Drawing.Point(16, 86);
            this.radioButtonLora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonLora.Name = "radioButtonLora";
            this.radioButtonLora.Size = new System.Drawing.Size(90, 19);
            this.radioButtonLora.TabIndex = 1;
            this.radioButtonLora.Text = "LoRa测试";
            this.radioButtonLora.UseVisualStyleBackColor = true;
            this.radioButtonLora.CheckedChanged += new System.EventHandler(this.radioButtonLora_CheckedChanged);
            // 
            // radioButtonPort
            // 
            this.radioButtonPort.AutoSize = true;
            this.radioButtonPort.Checked = true;
            this.radioButtonPort.Location = new System.Drawing.Point(16, 37);
            this.radioButtonPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPort.Name = "radioButtonPort";
            this.radioButtonPort.Size = new System.Drawing.Size(88, 19);
            this.radioButtonPort.TabIndex = 0;
            this.radioButtonPort.TabStop = true;
            this.radioButtonPort.Text = "普通串口";
            this.radioButtonPort.UseVisualStyleBackColor = true;
            this.radioButtonPort.CheckedChanged += new System.EventHandler(this.radioButtonPort_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 342);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "LoRa地址(16进制)";
            // 
            // textBoxLoraAddr
            // 
            this.textBoxLoraAddr.Location = new System.Drawing.Point(318, 339);
            this.textBoxLoraAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLoraAddr.MaxLength = 8;
            this.textBoxLoraAddr.Name = "textBoxLoraAddr";
            this.textBoxLoraAddr.Size = new System.Drawing.Size(157, 25);
            this.textBoxLoraAddr.TabIndex = 48;
            this.textBoxLoraAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoraAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoraAddr_KeyPress);
            this.textBoxLoraAddr.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLoraAddr_Validating);
            // 
            // checkBoxAutoAddr
            // 
            this.checkBoxAutoAddr.AutoSize = true;
            this.checkBoxAutoAddr.Location = new System.Drawing.Point(179, 378);
            this.checkBoxAutoAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAutoAddr.Name = "checkBoxAutoAddr";
            this.checkBoxAutoAddr.Size = new System.Drawing.Size(119, 19);
            this.checkBoxAutoAddr.TabIndex = 49;
            this.checkBoxAutoAddr.Text = "地址自动递增";
            this.checkBoxAutoAddr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 786);
            this.Controls.Add(this.checkBoxAutoAddr);
            this.Controls.Add(this.textBoxLoraAddr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton485;
        private System.Windows.Forms.RadioButton radioButtonLora;
        private System.Windows.Forms.RadioButton radioButtonPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLoraAddr;
        private System.Windows.Forms.CheckBox checkBoxAutoAddr;
    }
}

