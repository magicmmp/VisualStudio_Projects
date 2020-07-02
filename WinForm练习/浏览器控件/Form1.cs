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
    public partial class frmEditor : Form
    {
        public frmEditor(frmContainer parent, int counter)
        {
            InitializeComponent();
            fontsToolStripComboBox.SelectedIndex = 0;
            MdiParent = parent;
            Text = "Editor " + counter.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showHelpMenuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            helpToolStripMenuItem.Visible = item.Checked;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "点击了File菜单项";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "点击了File菜单项的 new 子项";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "点击了File菜单项的 open 子项";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "点击了File菜单项的 save 子项";
        }

        

        private void Form1_Load(object sender, EventArgs e)
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
            richTextBoxText.Focus();//让文本框获得焦点
            /**
             * 好像没有必要？  2020-6-30
             * 第一行从菜单项中删除事件处理程序，以确保下一行代码运行时不触发事件，第二行代码把 Checked 
             * 属性的状态设置为与工具栏按钮相同的值。最后，恢复事件处理程序
             */
            boldToolStripMenuItem.CheckedChanged -= new EventHandler(boldToolStripMenuItem_CheckedChanged);
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

        private void 呵呵呵ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelText.Text = "Number of characters: " + richTextBoxText.Text.Length;
        }
    }
}
