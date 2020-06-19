namespace TrackBar
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
            this.trackBarSetPower = new System.Windows.Forms.TrackBar();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.trackBarSetColor = new System.Windows.Forms.TrackBar();
            this.portNamesCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.turnOnButton = new System.Windows.Forms.CheckBox();
            this.ClearSendButton = new System.Windows.Forms.Button();
            this.hexadecimalSendCheckBox = new System.Windows.Forms.CheckBox();
            this.stopShowingButton = new System.Windows.Forms.CheckBox();
            this.autoClearCheckBox = new System.Windows.Forms.CheckBox();
            this.hexadecimalDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearReceiveButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.autoSendCycleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AutoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.countClearButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusSendByteTextBlock = new System.Windows.Forms.TextBox();
            this.statusReceiveByteTextBlock = new System.Windows.Forms.TextBox();
            this.statusTextBlock = new System.Windows.Forms.TextBox();
            this.autoDetectionTimer = new System.Windows.Forms.Timer(this.components);
            this.autoSendTimer = new System.Windows.Forms.Timer(this.components);
            this.timerSendCmd = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetColor)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarSetPower
            // 
            this.trackBarSetPower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBarSetPower.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarSetPower.Enabled = false;
            this.trackBarSetPower.Location = new System.Drawing.Point(141, 148);
            this.trackBarSetPower.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSetPower.Maximum = 100;
            this.trackBarSetPower.Name = "trackBarSetPower";
            this.trackBarSetPower.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSetPower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarSetPower.Size = new System.Drawing.Size(45, 334);
            this.trackBarSetPower.TabIndex = 1;
            this.trackBarSetPower.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSetPower.Value = 80;
            this.trackBarSetPower.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.BackColor = System.Drawing.SystemColors.Info;
            this.labelPower.Enabled = false;
            this.labelPower.Location = new System.Drawing.Point(203, 311);
            this.labelPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(65, 12);
            this.labelPower.TabIndex = 2;
            this.labelPower.Text = "功率：80 %";
            this.labelPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.SystemColors.Info;
            this.labelColor.Enabled = false;
            this.labelColor.Location = new System.Drawing.Point(385, 311);
            this.labelColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(65, 12);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "色温：80 %";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSetColor
            // 
            this.trackBarSetColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBarSetColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarSetColor.Enabled = false;
            this.trackBarSetColor.Location = new System.Drawing.Point(324, 148);
            this.trackBarSetColor.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSetColor.Maximum = 100;
            this.trackBarSetColor.Name = "trackBarSetColor";
            this.trackBarSetColor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSetColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarSetColor.Size = new System.Drawing.Size(45, 334);
            this.trackBarSetColor.TabIndex = 3;
            this.trackBarSetColor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSetColor.Value = 80;
            this.trackBarSetColor.ValueChanged += new System.EventHandler(this.trackBarSetColor_ValueChanged);
            // 
            // portNamesCombobox
            // 
            this.portNamesCombobox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portNamesCombobox.FormattingEnabled = true;
            this.portNamesCombobox.Location = new System.Drawing.Point(53, 78);
            this.portNamesCombobox.Name = "portNamesCombobox";
            this.portNamesCombobox.Size = new System.Drawing.Size(99, 28);
            this.portNamesCombobox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "端口";
            // 
            // turnOnButton
            // 
            this.turnOnButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.turnOnButton.AutoSize = true;
            this.turnOnButton.Location = new System.Drawing.Point(185, 83);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(63, 22);
            this.turnOnButton.TabIndex = 37;
            this.turnOnButton.Text = "打开串口";
            this.turnOnButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.CheckedChanged += new System.EventHandler(this.turnOnButton_CheckedChanged);
            // 
            // ClearSendButton
            // 
            this.ClearSendButton.Location = new System.Drawing.Point(5, 366);
            this.ClearSendButton.Name = "ClearSendButton";
            this.ClearSendButton.Size = new System.Drawing.Size(83, 47);
            this.ClearSendButton.TabIndex = 52;
            this.ClearSendButton.Text = "清空重填";
            this.ClearSendButton.UseVisualStyleBackColor = true;
            this.ClearSendButton.Visible = false;
            this.ClearSendButton.Click += new System.EventHandler(this.ClearSendButton_Click);
            // 
            // hexadecimalSendCheckBox
            // 
            this.hexadecimalSendCheckBox.AutoSize = true;
            this.hexadecimalSendCheckBox.Location = new System.Drawing.Point(3, 343);
            this.hexadecimalSendCheckBox.Name = "hexadecimalSendCheckBox";
            this.hexadecimalSendCheckBox.Size = new System.Drawing.Size(96, 16);
            this.hexadecimalSendCheckBox.TabIndex = 51;
            this.hexadecimalSendCheckBox.Text = "十六进制发送";
            this.hexadecimalSendCheckBox.UseVisualStyleBackColor = true;
            this.hexadecimalSendCheckBox.Visible = false;
            // 
            // stopShowingButton
            // 
            this.stopShowingButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.stopShowingButton.AutoSize = true;
            this.stopShowingButton.Location = new System.Drawing.Point(12, 219);
            this.stopShowingButton.Name = "stopShowingButton";
            this.stopShowingButton.Size = new System.Drawing.Size(63, 22);
            this.stopShowingButton.TabIndex = 50;
            this.stopShowingButton.Text = "停止显示";
            this.stopShowingButton.UseVisualStyleBackColor = true;
            this.stopShowingButton.Visible = false;
            this.stopShowingButton.CheckedChanged += new System.EventHandler(this.stopShowingButton_CheckedChanged);
            // 
            // autoClearCheckBox
            // 
            this.autoClearCheckBox.AutoSize = true;
            this.autoClearCheckBox.Location = new System.Drawing.Point(12, 197);
            this.autoClearCheckBox.Name = "autoClearCheckBox";
            this.autoClearCheckBox.Size = new System.Drawing.Size(72, 16);
            this.autoClearCheckBox.TabIndex = 49;
            this.autoClearCheckBox.Text = "自动清空";
            this.autoClearCheckBox.UseVisualStyleBackColor = true;
            this.autoClearCheckBox.Visible = false;
            // 
            // hexadecimalDisplayCheckBox
            // 
            this.hexadecimalDisplayCheckBox.AutoSize = true;
            this.hexadecimalDisplayCheckBox.Location = new System.Drawing.Point(12, 175);
            this.hexadecimalDisplayCheckBox.Name = "hexadecimalDisplayCheckBox";
            this.hexadecimalDisplayCheckBox.Size = new System.Drawing.Size(96, 16);
            this.hexadecimalDisplayCheckBox.TabIndex = 48;
            this.hexadecimalDisplayCheckBox.Text = "十六进制显示";
            this.hexadecimalDisplayCheckBox.UseVisualStyleBackColor = true;
            this.hexadecimalDisplayCheckBox.Visible = false;
            // 
            // ClearReceiveButton
            // 
            this.ClearReceiveButton.Location = new System.Drawing.Point(17, 247);
            this.ClearReceiveButton.Name = "ClearReceiveButton";
            this.ClearReceiveButton.Size = new System.Drawing.Size(63, 22);
            this.ClearReceiveButton.TabIndex = 47;
            this.ClearReceiveButton.Text = "清空接收区";
            this.ClearReceiveButton.UseVisualStyleBackColor = true;
            this.ClearReceiveButton.Visible = false;
            this.ClearReceiveButton.Click += new System.EventHandler(this.ClearReceiveButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 419);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(83, 47);
            this.SendButton.TabIndex = 46;
            this.SendButton.Text = "手动发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Visible = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "毫秒";
            this.label6.Visible = false;
            // 
            // autoSendCycleTextBox
            // 
            this.autoSendCycleTextBox.Location = new System.Drawing.Point(20, 294);
            this.autoSendCycleTextBox.MaxLength = 6;
            this.autoSendCycleTextBox.Name = "autoSendCycleTextBox";
            this.autoSendCycleTextBox.Size = new System.Drawing.Size(60, 21);
            this.autoSendCycleTextBox.TabIndex = 44;
            this.autoSendCycleTextBox.Text = "1000";
            this.autoSendCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.autoSendCycleTextBox.Visible = false;
            this.autoSendCycleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.autoSendCycleTextBox_KeyPress);
            this.autoSendCycleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.autoSendCycleTextBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 43;
            this.label7.Text = "自动发送周期";
            this.label7.Visible = false;
            // 
            // AutoSendCheckBox
            // 
            this.AutoSendCheckBox.AutoSize = true;
            this.AutoSendCheckBox.Location = new System.Drawing.Point(12, 321);
            this.AutoSendCheckBox.Name = "AutoSendCheckBox";
            this.AutoSendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoSendCheckBox.TabIndex = 42;
            this.AutoSendCheckBox.Text = "自动发送";
            this.AutoSendCheckBox.UseVisualStyleBackColor = true;
            this.AutoSendCheckBox.Visible = false;
            this.AutoSendCheckBox.CheckedChanged += new System.EventHandler(this.AutoSendCheckBox_CheckedChanged);
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.receiveTextBox.Location = new System.Drawing.Point(136, 485);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.ReadOnly = true;
            this.receiveTextBox.Size = new System.Drawing.Size(50, 21);
            this.receiveTextBox.TabIndex = 41;
            this.receiveTextBox.Text = "";
            this.receiveTextBox.Visible = false;
            this.receiveTextBox.TextChanged += new System.EventHandler(this.receiveTextBox_TextChanged);
            // 
            // sendTextBox
            // 
            this.sendTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sendTextBox.Location = new System.Drawing.Point(205, 490);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(43, 16);
            this.sendTextBox.TabIndex = 40;
            this.sendTextBox.Visible = false;
            this.sendTextBox.TextChanged += new System.EventHandler(this.sendTextBox_TextChanged);
            this.sendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendTextBox_KeyPress);
            // 
            // countClearButton
            // 
            this.countClearButton.Location = new System.Drawing.Point(275, 488);
            this.countClearButton.Name = "countClearButton";
            this.countClearButton.Size = new System.Drawing.Size(103, 23);
            this.countClearButton.TabIndex = 58;
            this.countClearButton.Text = "计数清零";
            this.countClearButton.UseVisualStyleBackColor = true;
            this.countClearButton.Visible = false;
            this.countClearButton.Click += new System.EventHandler(this.countClearButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 57;
            this.label9.Text = "接收字节数";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 56;
            this.label8.Text = "发送字节数";
            this.label8.Visible = false;
            // 
            // statusSendByteTextBlock
            // 
            this.statusSendByteTextBlock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusSendByteTextBlock.Location = new System.Drawing.Point(115, 542);
            this.statusSendByteTextBlock.Name = "statusSendByteTextBlock";
            this.statusSendByteTextBlock.Size = new System.Drawing.Size(88, 21);
            this.statusSendByteTextBlock.TabIndex = 55;
            this.statusSendByteTextBlock.Visible = false;
            // 
            // statusReceiveByteTextBlock
            // 
            this.statusReceiveByteTextBlock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusReceiveByteTextBlock.Location = new System.Drawing.Point(23, 542);
            this.statusReceiveByteTextBlock.Name = "statusReceiveByteTextBlock";
            this.statusReceiveByteTextBlock.Size = new System.Drawing.Size(69, 21);
            this.statusReceiveByteTextBlock.TabIndex = 54;
            this.statusReceiveByteTextBlock.Visible = false;
            // 
            // statusTextBlock
            // 
            this.statusTextBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.statusTextBlock.Location = new System.Drawing.Point(12, 473);
            this.statusTextBlock.Name = "statusTextBlock";
            this.statusTextBlock.ReadOnly = true;
            this.statusTextBlock.Size = new System.Drawing.Size(92, 21);
            this.statusTextBlock.TabIndex = 53;
            this.statusTextBlock.Text = "准备就绪";
            this.statusTextBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusTextBlock.Visible = false;
            // 
            // autoDetectionTimer
            // 
            this.autoDetectionTimer.Tick += new System.EventHandler(this.autoDetectionTimer_Tick);
            // 
            // autoSendTimer
            // 
            this.autoSendTimer.Interval = 1000;
            this.autoSendTimer.Tick += new System.EventHandler(this.autoSendTimer_Tick);
            // 
            // timerSendCmd
            // 
            this.timerSendCmd.Interval = 500;
            this.timerSendCmd.Tick += new System.EventHandler(this.timerSendCmd_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "485控制器双色温演示系统";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countClearButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusSendByteTextBlock);
            this.Controls.Add(this.statusReceiveByteTextBlock);
            this.Controls.Add(this.statusTextBlock);
            this.Controls.Add(this.ClearSendButton);
            this.Controls.Add(this.hexadecimalSendCheckBox);
            this.Controls.Add(this.stopShowingButton);
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
            this.Controls.Add(this.turnOnButton);
            this.Controls.Add(this.portNamesCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.trackBarSetColor);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.trackBarSetPower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(498, 628);
            this.MinimumSize = new System.Drawing.Size(498, 628);
            this.Name = "Form1";
            this.Text = "广东合创智控科技有限公司";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarSetPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TrackBar trackBarSetColor;
        private System.Windows.Forms.ComboBox portNamesCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox turnOnButton;
        private System.Windows.Forms.Button ClearSendButton;
        private System.Windows.Forms.CheckBox hexadecimalSendCheckBox;
        private System.Windows.Forms.CheckBox stopShowingButton;
        private System.Windows.Forms.CheckBox autoClearCheckBox;
        private System.Windows.Forms.CheckBox hexadecimalDisplayCheckBox;
        private System.Windows.Forms.Button ClearReceiveButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox autoSendCycleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox AutoSendCheckBox;
        private System.Windows.Forms.RichTextBox receiveTextBox;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Button countClearButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statusSendByteTextBlock;
        private System.Windows.Forms.TextBox statusReceiveByteTextBlock;
        private System.Windows.Forms.TextBox statusTextBlock;
        private System.Windows.Forms.Timer autoDetectionTimer;
        private System.Windows.Forms.Timer autoSendTimer;
        private System.Windows.Forms.Timer timerSendCmd;
        private System.Windows.Forms.Label label2;
    }
}

