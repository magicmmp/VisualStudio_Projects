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
            richTextBoxText.Text = item.Checked ? "显示编辑菜单" : "隐藏编辑菜单";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void boldToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            bool checkState = ((ToolStripButton)sender).Checked;
            oldFont = this.richTextBoxText.SelectionFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();
            //同步更新菜单项里面的粗体字选中状态
            //从菜单项中删除事件处理程序，以确保下一行代码运行时不触发事件
            boldToolStripMenuItem.CheckedChanged -= new
            EventHandler(boldToolStripMenuItem_CheckedChanged);//避免这两个函数循环调用
            boldToolStripMenuItem.Checked = checkState;
            boldToolStripMenuItem.CheckedChanged += new
            EventHandler(boldToolStripMenuItem_CheckedChanged);

            toolStripStatusLabelBold.Enabled = checkState;
        }

        private void boldToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            boldToolStripButton.Checked = boldToolStripMenuItem.Checked;
        }

        private void italicToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            italicToolStripButton.Checked = italicToolStripMenuItem.Checked;
        }

        private void underlineToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            underlineToolStripButton.Checked = underlineToolStripMenuItem.Checked;
        }

        private void italicToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            bool checkState = ((ToolStripButton)sender).Checked;
            oldFont = this.richTextBoxText.SelectionFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();
            italicToolStripMenuItem.CheckedChanged -= new
            EventHandler(italicToolStripMenuItem_CheckedChanged);
            italicToolStripMenuItem.Checked = checkState;
            italicToolStripMenuItem.CheckedChanged += new
            EventHandler(italicToolStripMenuItem_CheckedChanged);

            toolStripStatusLabelItalic.Enabled = checkState;
        }

        private void underlineToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            bool checkState = ((ToolStripButton)sender).Checked;
            oldFont = this.richTextBoxText.SelectionFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();
            underlineToolStripMenuItem.CheckedChanged -= new
            EventHandler(underlineToolStripMenuItem_CheckedChanged);
            underlineToolStripMenuItem.Checked = checkState;
            underlineToolStripMenuItem.CheckedChanged += new
            EventHandler(underlineToolStripMenuItem_CheckedChanged);

            toolStripStatusLabelUnderline.Enabled = checkState;
        }

        private void fontsToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ((ToolStripComboBox)sender).SelectedItem.ToString();
            Font newFont = null;
            if (richTextBoxText.SelectionFont == null)
                newFont = new Font(text, richTextBoxText.Font.Size);
            else
                newFont = new Font(text, richTextBoxText.SelectionFont.Size,
                richTextBoxText.SelectionFont.Style);
            richTextBoxText.SelectionFont = newFont;
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelText.Text = "Number of characters: " +
                                            richTextBoxText.Text.Length;
        }
    }
}
