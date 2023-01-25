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

namespace PictureBox
{
    public partial class Form1 : Form
    {
        string[] picPath;//保存图片的路径
        int i = 0;//下标
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;//缩放尺寸
            //获得文件夹下所有图片的路径
            picPath = Directory.GetFiles(@"E:\清水河毕业照", "*.jpg");
            if(picPath.Length>0)
                pictureBox1.Image = Image.FromFile(picPath[0]);
        }
        //点击pictureBox控件也会显示下一张图片
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i++;
            if (i == picPath.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(picPath[i]);
        }
        //显示下一张图片
        private void button_next_Click(object sender, EventArgs e)
        {
            i++;
            if (i == picPath.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(picPath[i]);
        }
        //显示上一张图片
        private void button_pre_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = picPath.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(picPath[i]);
        }
    }
}
