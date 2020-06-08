using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=textBox_Input.Text;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Input_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
