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

namespace OpenFileDialog_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //打开对话框
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //在Show出来之前设置对话框的属性
            //设置初始目录
            ofd.InitialDirectory = @"C:\Users\pss\Desktop";
            //设置对话框显示的标题
            ofd.Title = "请选择要打开的文件";
            //用来控制出现在文件类型框中出现的选择内容
            ofd.Filter = "文本文件|*.txt|视频文件|*.wmv|图片文件|*.jpg|所有文件|*.*";
            //设置对话框可以多选，默认FALSE
            //ofd.Multiselect = true;
            ofd.ShowDialog();
            //在打开对话框中获得选中的文件的路径
            string path = ofd.FileName;
            if (!string.IsNullOrEmpty(path))//判断字符串是否为空
            {
                txtConent.Text = File.ReadAllText(path, Encoding.UTF8);
            }
        }
        //设置保存对话框的初始路径
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置保存对话框的初始路径
            sfd.InitialDirectory = @"C:\Users\pss\Desktop";
            //设置保存对话框显示的标题
            sfd.Title = "请选择要保存文件的路径";
            //保存对话框是否有多选？ 没有多选
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();
            //获得在保存对话框中选中的路径
            string savePath = sfd.FileName;
            if (!string.IsNullOrEmpty(savePath))
            {
                File.WriteAllText(savePath, txtConent.Text);
                MessageBox.Show("保存成功");
            }
        }
        //打开颜色选择对话框，设置字体颜色
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            txtConent.ForeColor = cd.Color;//字体颜色是ForeColor，背景颜色是BackColor
        }
        //打开字体对话框
        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            //将在字体对话框中选择的字体赋值给文本框中的字体
            txtConent.Font = fd.Font;
        }
        private void txtConent_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtConent.ScrollBars = ScrollBars.Both;
        }
    }
}
