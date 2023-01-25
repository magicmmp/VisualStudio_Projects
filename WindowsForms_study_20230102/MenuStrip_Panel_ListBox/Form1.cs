using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_Panel_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        List<string> listPath = new List<string>();//存储打开文件全路径的泛型集合
        //打开文本文件
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string path = ofd.FileName;
            if(!string.IsNullOrEmpty(path))
            {
                //把每次打开的文件的路径都添加到集合中
                listPath.Add(path);
                //将打开的文件的名字添加到ListBox中
                listBox1.Items.Add(Path.GetFileName(path));
                textBox1.Text = File.ReadAllText(path, Encoding.UTF8);
            }
        }
        //双击显示对应的文件中的数据
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //获得双击的文件的全路径
            textBox1.Text = File.ReadAllText(listPath[listBox1.SelectedIndex]);
        }
    }
}
