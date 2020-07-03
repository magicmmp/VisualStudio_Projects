using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s1 = "ssdd";
            string s2 = "ssa";
            string s3 = "";
            textBox1.AppendText("s1= "+s1+"\r\n");
            textBox1.AppendText("s2= " + s2 + "\r\n");
            textBox1.AppendText("s1");
            if (!s1.StartsWith(s2))
            {
                textBox1.AppendText(" 不");
                s3 = "???";
            }
            else
            {
                s3 = s1.Substring(s2.Length);
            }
            textBox1.AppendText("以 s2 开始" + "\r\n");
            textBox1.AppendText("s3=" + s3 + "\r\n");

        }
    }
}
