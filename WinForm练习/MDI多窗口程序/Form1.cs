using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI多窗口程序
{
    public partial class frmContainer : Form
    {
        public frmContainer()
        {
            InitializeComponent();
            frmChild child = new frmChild(this);
            child.Show();
            Form3 child2 = new Form3(this);
            child2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
