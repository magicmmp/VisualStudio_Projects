namespace WinForm练习
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
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.buttonDanish = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Image = global::WinForm练习.Properties.Resources.logo1;
            this.buttonEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnglish.Location = new System.Drawing.Point(35, 12);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(437, 175);
            this.buttonEnglish.TabIndex = 0;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // buttonDanish
            // 
            this.buttonDanish.Location = new System.Drawing.Point(546, 63);
            this.buttonDanish.Name = "buttonDanish";
            this.buttonDanish.Size = new System.Drawing.Size(75, 23);
            this.buttonDanish.TabIndex = 1;
            this.buttonDanish.Text = "Danish";
            this.buttonDanish.UseVisualStyleBackColor = true;
            this.buttonDanish.Click += new System.EventHandler(this.buttonDanish_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(397, 342);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(60, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 84);
            this.textBox1.TabIndex = 3;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDanish);
            this.Controls.Add(this.buttonEnglish);
            this.Name = "Form1";
            this.Text = "窗口名称";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button buttonDanish;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBox1;
    }
}

