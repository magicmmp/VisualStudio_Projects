using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        Uri uri;//webBrowser1.Url是Uri格式的网址
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //前往输入框的网址
        private void button_go_Click(object sender, EventArgs e)
        {
            if (textBox_URL.Text.Contains("https://"))
            {
                uri = new Uri(textBox_URL.Text.Trim());
            }
            else
            {
                uri = new Uri("https://" + textBox_URL.Text.Trim());
            }
            webBrowser1.Url = uri;//只需要赋值给浏览器控件的URL属性即可
        }
    }
}
