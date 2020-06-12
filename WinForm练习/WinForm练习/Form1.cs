using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDanish_Click(object sender, EventArgs e)
        {
            Text = "荷兰语";
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            Text = "猪头";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
