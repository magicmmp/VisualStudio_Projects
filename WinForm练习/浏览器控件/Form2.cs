using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 浏览器控件
{
    public partial class frmContainer : Form
    {
        private int counter;
        public frmContainer()
        {
            InitializeComponent();
            counter = 1;
            frmEditor editor = new frmEditor(this,counter);
            editor.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor newForm = new frmEditor(this, ++counter);
            newForm.Show();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);//多个窗口平铺排列
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);//多个窗口瀑布排列
        }
    }
}
