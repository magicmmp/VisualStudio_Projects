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

namespace ListBox_showPictureList
{
    public partial class Form1 : Form
    {
        string[] filePath;//存放一个文件夹下照片的绝对路径
        public Form1()
        {
            InitializeComponent();
        }
        //程序加载时运行Form1_Load方法
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;//设置
            //将文件夹中所有照片的绝对路径保存在数组
            //后缀表示只获取JPG格式文件的绝对路径
            filePath = Directory.GetFiles(@"E:\清水河毕业照", "*.jpg");
            for (int i = 0; i < filePath.Length; i++)
            {
                //截取出文件名并且加载到ListBox中，不带后缀
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(filePath[i]));
            }
        }
        //当选中项的索引发生改变的时候，PictureBox显示对应的图片
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //需要通过listBox1被选中项的索引来获取数组中的数据
            pictureBox1.Image = Image.FromFile(filePath[listBox1.SelectedIndex]);//需要绝对路径
        }
    }
}
