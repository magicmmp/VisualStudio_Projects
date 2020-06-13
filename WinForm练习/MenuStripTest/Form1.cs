using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fontsToolStripComboBox.SelectedIndex = 0;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新建选项被点击");
        }

        private void showHelpMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showHelpMenuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            editToolStripMenuItem.Visible = item.Checked;
            richTextBox1.Text = item.Checked ? "显示编辑菜单" : "隐藏编辑菜单";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
