﻿namespace WindowsForms_Button
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
            this.buttom1 = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttom1
            // 
            this.buttom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttom1.Image = global::WindowsForms_Button.Properties.Resources.button1;
            this.buttom1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttom1.Location = new System.Drawing.Point(369, 40);
            this.buttom1.Name = "buttom1";
            this.buttom1.Size = new System.Drawing.Size(258, 166);
            this.buttom1.TabIndex = 0;
            this.buttom1.Text = "按钮1";
            this.buttom1.UseVisualStyleBackColor = true;
            this.buttom1.Click += new System.EventHandler(this.button1_Click);
            this.buttom1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Input_Validating);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(33, 40);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(269, 69);
            this.textBox_Input.TabIndex = 1;
            this.textBox_Input.TabStop = false;
            this.textBox_Input.Text = "heheh";
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            this.textBox_Input.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Input_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.buttom1);
            this.Name = "Form1";
            this.Text = "Do you speak English?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttom1;
        protected internal System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label1;
    }
}

