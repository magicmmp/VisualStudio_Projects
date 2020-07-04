﻿namespace SerialPort_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBox485ResendTimes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonNextAddr = new System.Windows.Forms.Button();
            this.buttonPreAddr = new System.Windows.Forms.Button();
            this.label_LoRaPreAddr = new System.Windows.Forms.Label();
            this.textBoxPreAddr = new System.Windows.Forms.TextBox();
            this.labelDataCode = new System.Windows.Forms.Label();
            this.labelDeviceType = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelInputVoltage = new System.Windows.Forms.Label();
            this.label_A_InputCurrent = new System.Windows.Forms.Label();
            this.label_B_InputCurrent = new System.Windows.Forms.Label();
            this.label_A_Power = new System.Windows.Forms.Label();
            this.label_B_PowerFactor = new System.Windows.Forms.Label();
            this.label_A_luminosity = new System.Windows.Forms.Label();
            this.label_A_PowerFactor = new System.Windows.Forms.Label();
            this.label_B_Power = new System.Windows.Forms.Label();
            this.label_B_luminosity = new System.Windows.Forms.Label();
            this.labelLoraStaus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.sendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sendTextBox.Location = new System.Drawing.Point(394, 424);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(682, 196);
            this.sendTextBox.TabIndex = 22;
            this.sendTextBox.TextChanged += new System.EventHandler(this.sendTextBox_TextChanged);
            this.sendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendTextBox_KeyPress);
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.receiveTextBox.Location = new System.Drawing.Point(394, 223);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.ReadOnly = true;
            this.receiveTextBox.Size = new System.Drawing.Size(682, 181);
            this.receiveTextBox.TabIndex = 23;
            this.receiveTextBox.Text = "";
            this.receiveTextBox.TextChanged += new System.EventHandler(this.receiveTextBox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(273, 510);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(83, 47);
            this.SendButton.TabIndex = 31;
            this.SendButton.Text = "手动发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "毫秒";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // autoSendCycleTextBox
            // 
            this.autoSendCycleTextBox.Location = new System.Drawing.Point(95, 424);
            this.autoSendCycleTextBox.MaxLength = 6;
            this.autoSendCycleTextBox.Name = "autoSendCycleTextBox";
            this.autoSendCycleTextBox.Size = new System.Drawing.Size(60, 21);
            this.autoSendCycleTextBox.TabIndex = 29;
            this.autoSendCycleTextBox.Text = "1500";
            this.autoSendCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.autoSendCycleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoraAddr_KeyPress);
            this.autoSendCycleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.autoSendCycleTextBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "自动发送周期";
            // 
            // AutoSendCheckBox
            // 
            this.AutoSendCheckBox.AutoSize = true;
            this.AutoSendCheckBox.Location = new System.Drawing.Point(17, 468);
            this.AutoSendCheckBox.Name = "AutoSendCheckBox";
            this.AutoSendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoSendCheckBox.TabIndex = 27;
            this.AutoSendCheckBox.Text = "自动发送";
            this.AutoSendCheckBox.UseVisualStyleBackColor = true;
            this.AutoSendCheckBox.CheckedChanged += new System.EventHandler(this.AutoSendCheckBox_CheckedChanged);
            this.AutoSendCheckBox.CheckStateChanged += new System.EventHandler(this.AutoSendCheckBox_CheckStateChanged);
            // 
            // ClearReceiveButton
            // 
            this.ClearReceiveButton.Location = new System.Drawing.Point(314, 70);
            this.ClearReceiveButton.Name = "ClearReceiveButton";
            this.ClearReceiveButton.Size = new System.Drawing.Size(63, 22);
            this.ClearReceiveButton.TabIndex = 32;
            this.ClearReceiveButton.Text = "清空接收区";
            this.ClearReceiveButton.UseVisualStyleBackColor = true;
            this.ClearReceiveButton.Click += new System.EventHandler(this.ClearReceiveButton_Click);
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
            this.turnOnButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.stopShowingButton.CheckedChanged += new System.EventHandler(this.stopShowingButton_CheckedChanged);
            // 
            // hexadecimalSendCheckBox
            // 
            this.hexadecimalSendCheckBox.AutoSize = true;
            this.hexadecimalSendCheckBox.Location = new System.Drawing.Point(141, 468);
            this.hexadecimalSendCheckBox.Name = "hexadecimalSendCheckBox";
            this.hexadecimalSendCheckBox.Size = new System.Drawing.Size(96, 16);
            this.hexadecimalSendCheckBox.TabIndex = 38;
            this.hexadecimalSendCheckBox.Text = "十六进制发送";
            this.hexadecimalSendCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearSendButton
            // 
            this.ClearSendButton.Location = new System.Drawing.Point(26, 510);
            this.ClearSendButton.Name = "ClearSendButton";
            this.ClearSendButton.Size = new System.Drawing.Size(83, 47);
            this.ClearSendButton.TabIndex = 39;
            this.ClearSendButton.Text = "清空重填";
            this.ClearSendButton.UseVisualStyleBackColor = true;
            this.ClearSendButton.Click += new System.EventHandler(this.ClearSendButton_Click);
            // 
            // statusTextBlock
            // 
            this.statusTextBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.statusTextBlock.Location = new System.Drawing.Point(17, 645);
            this.statusTextBlock.Name = "statusTextBlock";
            this.statusTextBlock.ReadOnly = true;
            this.statusTextBlock.Size = new System.Drawing.Size(114, 21);
            this.statusTextBlock.TabIndex = 40;
            this.statusTextBlock.Text = "准备就绪";
            this.statusTextBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusReceiveByteTextBlock
            // 
            this.statusReceiveByteTextBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusReceiveByteTextBlock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusReceiveByteTextBlock.Location = new System.Drawing.Point(567, 645);
            this.statusReceiveByteTextBlock.Name = "statusReceiveByteTextBlock";
            this.statusReceiveByteTextBlock.Size = new System.Drawing.Size(108, 21);
            this.statusReceiveByteTextBlock.TabIndex = 41;
            this.statusReceiveByteTextBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusSendByteTextBlock
            // 
            this.statusSendByteTextBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusSendByteTextBlock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusSendByteTextBlock.Location = new System.Drawing.Point(826, 645);
            this.statusSendByteTextBlock.Name = "statusSendByteTextBlock";
            this.statusSendByteTextBlock.Size = new System.Drawing.Size(106, 21);
            this.statusSendByteTextBlock.TabIndex = 42;
            this.statusSendByteTextBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(726, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "发送字节数";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 645);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "接收字节数";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // countClearButton
            // 
            this.countClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countClearButton.Location = new System.Drawing.Point(989, 645);
            this.countClearButton.Name = "countClearButton";
            this.countClearButton.Size = new System.Drawing.Size(74, 23);
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
            this.autoSendTimer.Interval = 1500;
            this.autoSendTimer.Tick += new System.EventHandler(this.AutoSendTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.radioButton485);
            this.groupBox1.Controls.Add(this.radioButtonLora);
            this.groupBox1.Controls.Add(this.radioButtonPort);
            this.groupBox1.Location = new System.Drawing.Point(14, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 152);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用途";
            // 
            // radioButton485
            // 
            this.radioButton485.AutoSize = true;
            this.radioButton485.Location = new System.Drawing.Point(12, 107);
            this.radioButton485.Name = "radioButton485";
            this.radioButton485.Size = new System.Drawing.Size(65, 16);
            this.radioButton485.TabIndex = 2;
            this.radioButton485.Text = "485测试";
            this.radioButton485.UseVisualStyleBackColor = true;
            this.radioButton485.CheckedChanged += new System.EventHandler(this.radioButton485_CheckedChanged);
            // 
            // radioButtonLora
            // 
            this.radioButtonLora.AutoSize = true;
            this.radioButtonLora.Location = new System.Drawing.Point(12, 69);
            this.radioButtonLora.Name = "radioButtonLora";
            this.radioButtonLora.Size = new System.Drawing.Size(71, 16);
            this.radioButtonLora.TabIndex = 1;
            this.radioButtonLora.Text = "LoRa测试";
            this.radioButtonLora.UseVisualStyleBackColor = true;
            this.radioButtonLora.CheckedChanged += new System.EventHandler(this.radioButtonLora_CheckedChanged);
            // 
            // radioButtonPort
            // 
            this.radioButtonPort.AutoSize = true;
            this.radioButtonPort.Checked = true;
            this.radioButtonPort.Location = new System.Drawing.Point(12, 30);
            this.radioButtonPort.Name = "radioButtonPort";
            this.radioButtonPort.Size = new System.Drawing.Size(71, 16);
            this.radioButtonPort.TabIndex = 0;
            this.radioButtonPort.TabStop = true;
            this.radioButtonPort.Text = "普通串口";
            this.radioButtonPort.UseVisualStyleBackColor = true;
            this.radioButtonPort.CheckedChanged += new System.EventHandler(this.radioButtonPort_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "下一个LoRa地址(Hex)";
            // 
            // textBoxLoraAddr
            // 
            this.textBoxLoraAddr.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLoraAddr.Location = new System.Drawing.Point(257, 271);
            this.textBoxLoraAddr.MaxLength = 6;
            this.textBoxLoraAddr.Name = "textBoxLoraAddr";
            this.textBoxLoraAddr.Size = new System.Drawing.Size(120, 47);
            this.textBoxLoraAddr.TabIndex = 48;
            this.textBoxLoraAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoraAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoraAddr_KeyPress);
            this.textBoxLoraAddr.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLoraAddr_Validating);
            // 
            // checkBoxAutoAddr
            // 
            this.checkBoxAutoAddr.AutoSize = true;
            this.checkBoxAutoAddr.Location = new System.Drawing.Point(134, 302);
            this.checkBoxAutoAddr.Name = "checkBoxAutoAddr";
            this.checkBoxAutoAddr.Size = new System.Drawing.Size(96, 16);
            this.checkBoxAutoAddr.TabIndex = 49;
            this.checkBoxAutoAddr.Text = "地址自动递增";
            this.checkBoxAutoAddr.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 50;
            this.label11.Text = "485命令重发次数";
            // 
            // textBox485ResendTimes
            // 
            this.textBox485ResendTimes.Location = new System.Drawing.Point(257, 363);
            this.textBox485ResendTimes.MaxLength = 8;
            this.textBox485ResendTimes.Name = "textBox485ResendTimes";
            this.textBox485ResendTimes.Size = new System.Drawing.Size(100, 21);
            this.textBox485ResendTimes.TabIndex = 51;
            this.textBox485ResendTimes.Text = "1";
            this.textBox485ResendTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox485ResendTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.autoSendCycleTextBox_KeyPress);
            this.textBox485ResendTimes.Validating += new System.ComponentModel.CancelEventHandler(this.textBox485ResendTimes_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 52;
            this.label12.Text = "剩余次数：0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 53;
            this.label13.Text = "字数：0";
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.label13_Click_1);
            // 
            // buttonNextAddr
            // 
            this.buttonNextAddr.Image = global::SerialPort_Test.Properties.Resources.下一首图标1;
            this.buttonNextAddr.Location = new System.Drawing.Point(341, 237);
            this.buttonNextAddr.Name = "buttonNextAddr";
            this.buttonNextAddr.Size = new System.Drawing.Size(36, 23);
            this.buttonNextAddr.TabIndex = 55;
            this.buttonNextAddr.UseVisualStyleBackColor = true;
            this.buttonNextAddr.Click += new System.EventHandler(this.buttonNextAddr_Click);
            // 
            // buttonPreAddr
            // 
            this.buttonPreAddr.Image = global::SerialPort_Test.Properties.Resources.上一首图标1;
            this.buttonPreAddr.Location = new System.Drawing.Point(257, 237);
            this.buttonPreAddr.Name = "buttonPreAddr";
            this.buttonPreAddr.Size = new System.Drawing.Size(36, 23);
            this.buttonPreAddr.TabIndex = 54;
            this.buttonPreAddr.UseVisualStyleBackColor = true;
            this.buttonPreAddr.Click += new System.EventHandler(this.buttonPreAddr_Click);
            // 
            // label_LoRaPreAddr
            // 
            this.label_LoRaPreAddr.AutoSize = true;
            this.label_LoRaPreAddr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_LoRaPreAddr.Location = new System.Drawing.Point(131, 332);
            this.label_LoRaPreAddr.Name = "label_LoRaPreAddr";
            this.label_LoRaPreAddr.Size = new System.Drawing.Size(98, 14);
            this.label_LoRaPreAddr.TabIndex = 56;
            this.label_LoRaPreAddr.Text = "原始地址(Hex)";
            // 
            // textBoxPreAddr
            // 
            this.textBoxPreAddr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPreAddr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPreAddr.Location = new System.Drawing.Point(257, 329);
            this.textBoxPreAddr.MaxLength = 6;
            this.textBoxPreAddr.Name = "textBoxPreAddr";
            this.textBoxPreAddr.Size = new System.Drawing.Size(120, 23);
            this.textBoxPreAddr.TabIndex = 57;
            this.textBoxPreAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPreAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoraAddr_KeyPress);
            this.textBoxPreAddr.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPreAddr_Validating);
            // 
            // labelDataCode
            // 
            this.labelDataCode.AutoSize = true;
            this.labelDataCode.Enabled = false;
            this.labelDataCode.Location = new System.Drawing.Point(413, 16);
            this.labelDataCode.Name = "labelDataCode";
            this.labelDataCode.Size = new System.Drawing.Size(53, 12);
            this.labelDataCode.TabIndex = 58;
            this.labelDataCode.Text = "数据标识";
            // 
            // labelDeviceType
            // 
            this.labelDeviceType.AutoSize = true;
            this.labelDeviceType.Enabled = false;
            this.labelDeviceType.Location = new System.Drawing.Point(413, 57);
            this.labelDeviceType.Name = "labelDeviceType";
            this.labelDeviceType.Size = new System.Drawing.Size(41, 12);
            this.labelDeviceType.TabIndex = 59;
            this.labelDeviceType.Text = "设备码";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Enabled = false;
            this.labelTemperature.Location = new System.Drawing.Point(413, 139);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(29, 12);
            this.labelTemperature.TabIndex = 60;
            this.labelTemperature.Text = "温度";
            // 
            // labelInputVoltage
            // 
            this.labelInputVoltage.AutoSize = true;
            this.labelInputVoltage.Enabled = false;
            this.labelInputVoltage.Location = new System.Drawing.Point(413, 98);
            this.labelInputVoltage.Name = "labelInputVoltage";
            this.labelInputVoltage.Size = new System.Drawing.Size(53, 12);
            this.labelInputVoltage.TabIndex = 61;
            this.labelInputVoltage.Text = "输入电压";
            // 
            // label_A_InputCurrent
            // 
            this.label_A_InputCurrent.AutoSize = true;
            this.label_A_InputCurrent.Enabled = false;
            this.label_A_InputCurrent.Location = new System.Drawing.Point(655, 16);
            this.label_A_InputCurrent.Name = "label_A_InputCurrent";
            this.label_A_InputCurrent.Size = new System.Drawing.Size(71, 12);
            this.label_A_InputCurrent.TabIndex = 62;
            this.label_A_InputCurrent.Text = "A路输入电流";
            // 
            // label_B_InputCurrent
            // 
            this.label_B_InputCurrent.AutoSize = true;
            this.label_B_InputCurrent.Enabled = false;
            this.label_B_InputCurrent.Location = new System.Drawing.Point(915, 16);
            this.label_B_InputCurrent.Name = "label_B_InputCurrent";
            this.label_B_InputCurrent.Size = new System.Drawing.Size(71, 12);
            this.label_B_InputCurrent.TabIndex = 63;
            this.label_B_InputCurrent.Text = "B路输入电流";
            // 
            // label_A_Power
            // 
            this.label_A_Power.AutoSize = true;
            this.label_A_Power.Enabled = false;
            this.label_A_Power.Location = new System.Drawing.Point(655, 71);
            this.label_A_Power.Name = "label_A_Power";
            this.label_A_Power.Size = new System.Drawing.Size(71, 12);
            this.label_A_Power.TabIndex = 64;
            this.label_A_Power.Text = "A路有功功率";
            // 
            // label_B_PowerFactor
            // 
            this.label_B_PowerFactor.AutoSize = true;
            this.label_B_PowerFactor.Enabled = false;
            this.label_B_PowerFactor.Location = new System.Drawing.Point(915, 181);
            this.label_B_PowerFactor.Name = "label_B_PowerFactor";
            this.label_B_PowerFactor.Size = new System.Drawing.Size(71, 12);
            this.label_B_PowerFactor.TabIndex = 68;
            this.label_B_PowerFactor.Text = "B路功率因素";
            // 
            // label_A_luminosity
            // 
            this.label_A_luminosity.AutoSize = true;
            this.label_A_luminosity.Enabled = false;
            this.label_A_luminosity.Location = new System.Drawing.Point(655, 126);
            this.label_A_luminosity.Name = "label_A_luminosity";
            this.label_A_luminosity.Size = new System.Drawing.Size(47, 12);
            this.label_A_luminosity.TabIndex = 67;
            this.label_A_luminosity.Text = "A路亮度";
            // 
            // label_A_PowerFactor
            // 
            this.label_A_PowerFactor.AutoSize = true;
            this.label_A_PowerFactor.Enabled = false;
            this.label_A_PowerFactor.Location = new System.Drawing.Point(655, 181);
            this.label_A_PowerFactor.Name = "label_A_PowerFactor";
            this.label_A_PowerFactor.Size = new System.Drawing.Size(71, 12);
            this.label_A_PowerFactor.TabIndex = 66;
            this.label_A_PowerFactor.Text = "A路功率因素";
            // 
            // label_B_Power
            // 
            this.label_B_Power.AutoSize = true;
            this.label_B_Power.Enabled = false;
            this.label_B_Power.Location = new System.Drawing.Point(915, 71);
            this.label_B_Power.Name = "label_B_Power";
            this.label_B_Power.Size = new System.Drawing.Size(71, 12);
            this.label_B_Power.TabIndex = 65;
            this.label_B_Power.Text = "B路有功功率";
            // 
            // label_B_luminosity
            // 
            this.label_B_luminosity.AutoSize = true;
            this.label_B_luminosity.Enabled = false;
            this.label_B_luminosity.Location = new System.Drawing.Point(915, 126);
            this.label_B_luminosity.Name = "label_B_luminosity";
            this.label_B_luminosity.Size = new System.Drawing.Size(47, 12);
            this.label_B_luminosity.TabIndex = 69;
            this.label_B_luminosity.Text = "B路亮度";
            // 
            // labelLoraStaus
            // 
            this.labelLoraStaus.AutoSize = true;
            this.labelLoraStaus.Enabled = false;
            this.labelLoraStaus.Location = new System.Drawing.Point(413, 180);
            this.labelLoraStaus.Name = "labelLoraStaus";
            this.labelLoraStaus.Size = new System.Drawing.Size(29, 12);
            this.labelLoraStaus.TabIndex = 70;
            this.labelLoraStaus.Text = "状态";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 692);
            this.Controls.Add(this.labelLoraStaus);
            this.Controls.Add(this.label_B_luminosity);
            this.Controls.Add(this.label_B_PowerFactor);
            this.Controls.Add(this.label_A_luminosity);
            this.Controls.Add(this.label_A_PowerFactor);
            this.Controls.Add(this.label_B_Power);
            this.Controls.Add(this.label_A_Power);
            this.Controls.Add(this.label_B_InputCurrent);
            this.Controls.Add(this.label_A_InputCurrent);
            this.Controls.Add(this.labelInputVoltage);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelDeviceType);
            this.Controls.Add(this.labelDataCode);
            this.Controls.Add(this.textBoxPreAddr);
            this.Controls.Add(this.label_LoRaPreAddr);
            this.Controls.Add(this.buttonNextAddr);
            this.Controls.Add(this.buttonPreAddr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox485ResendTimes);
            this.Controls.Add(this.label11);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1104, 730);
            this.MinimumSize = new System.Drawing.Size(1104, 730);
            this.Name = "Form1";
            this.Text = "串口调试助手";
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox485ResendTimes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonPreAddr;
        private System.Windows.Forms.Button buttonNextAddr;
        private System.Windows.Forms.Label label_LoRaPreAddr;
        private System.Windows.Forms.TextBox textBoxPreAddr;
        private System.Windows.Forms.Label labelDataCode;
        private System.Windows.Forms.Label labelDeviceType;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelInputVoltage;
        private System.Windows.Forms.Label label_A_InputCurrent;
        private System.Windows.Forms.Label label_B_InputCurrent;
        private System.Windows.Forms.Label label_A_Power;
        private System.Windows.Forms.Label label_B_PowerFactor;
        private System.Windows.Forms.Label label_A_luminosity;
        private System.Windows.Forms.Label label_A_PowerFactor;
        private System.Windows.Forms.Label label_B_Power;
        private System.Windows.Forms.Label label_B_luminosity;
        private System.Windows.Forms.Label labelLoraStaus;
    }
}

