using GDI__test.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightPink;
            //谁要画图就创建一个Graphics对象
            Graphics g = this.CreateGraphics();//给本窗体创建一个GDI对象
            Graphics g2 = button1.CreateGraphics();//给按钮创建一个GDI对象
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //使用GDI+来绘制一条直线
            Graphics g = this.CreateGraphics();//在窗体绘制，就利用窗体对象获得Graphics对象
            Point p1 = new Point(30, 30);//一个点对象
            Point p2 = new Point(190, 190);
            Pen p = new Pen(Brushes.Brown);//画笔对象，设置为棕色
            g.DrawLine(p, p1, p2);//画直线
        }
        //当窗体显示需要重新绘制时调用
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point p1 = new Point(230, 230);
            Point p2 = new Point(390, 390);
            Pen p = new Pen(Brushes.Brown);
            g.DrawLine(p, p1, p2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //画矩形
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Brushes.Red);
            Rectangle rec = new Rectangle(69, 89, 200, 200);//参数：矩形左上角坐标X和Y，宽和高
            g.DrawRectangle(p, rec);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //画扇形
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Brushes.Red);
            Rectangle rec = new Rectangle(69, 89, 200, 200);
            g.DrawPie(p, rec, 180, 90);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //画字符串
            Graphics g = this.CreateGraphics();
            g.DrawString("GDI绘制的字符串", new Font("宋体", 20, FontStyle.Bold), Brushes.Yellow, new Point(222, 222));
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //绘制项目资源的一张图片
            Graphics g = this.CreateGraphics();
            //项目Resources的图片资源名称不需要后缀
            //需要添加当前项目的Properties命名空间，如GDI__test.Properties;
            g.DrawImage(Resources.grape, new Point(0, 0));//点坐标是绘制图片的左上角位置
        }
        Random r = new Random();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //1、创建Bitmap图片对象
            Bitmap bmp = new Bitmap(320, 80);//指定图片宽320像素，高80像素
            //2、从图片对象创建一个GDI+对象，因为验证码要画在图片上
            Graphics g = Graphics.FromImage(bmp);
            string str = string.Empty;
            //3、产生随机数
            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            string[] fonts = { "微软雅黑", "宋体", "隶书", "仿宋", "楷体" };
            int[] size = { 25, 16, 18, 15, 20 };
            Color[] colors = { Color.Red, Color.Black, Color.Yellow, Color.Green, Color.Blue };
            //一个一个的绘制数字。每个数字的字体颜色都是随机的
            for (int i = 0; i < str.Length; i++)
            {
                Point p = new Point(i*bmp.Width/6, bmp.Height/4);//Point是以像素点为单位的
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], size[r.Next(0, 5)], FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);
            }
            //4、给验证码图片添加随机直线
            for (int i = 0; i < 20; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }
            //5、给验证码图片添加像素颗粒
            for (int i = 0; i < 200; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                //设置图片像素的颜色
                bmp.SetPixel(p1.X, p1.Y, Color.Black);
            }
            //把图片放置到PictureBox上
            pictureBox1.Image = bmp;
        }
    }
}
