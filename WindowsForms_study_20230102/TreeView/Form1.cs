using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //添加根节点
        private void button1_Click(object sender, EventArgs e)
        {
            //Nodes表示获得TreeView控件中节点的集合
            treeView1.Nodes.Add(txtParent.Text);
        }
        //添加子节点
        private void button2_Click(object sender, EventArgs e)
        {
            //获得当前选中的节点 返回当前选中的节点
            TreeNode tn = treeView1.SelectedNode;
            tn.Nodes.Add(txtChild.Text);
        }
        //更改节点名称
        private void button3_Click(object sender, EventArgs e)
        {
            //获得当前选中的节点 
            TreeNode tn = treeView1.SelectedNode;
            tn.Text = txtChange.Text;
        }
        //展开全部节点
        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
        //折叠全部节点
        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
