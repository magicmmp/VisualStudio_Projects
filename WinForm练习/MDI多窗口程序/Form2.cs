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
    public partial class frmChild : Form
    {
        //自定义有参构造函数，传入它的父窗体引用
        public frmChild(frmContainer parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void frmChild_Load(object sender, EventArgs e)
        {

        }
    }
}
