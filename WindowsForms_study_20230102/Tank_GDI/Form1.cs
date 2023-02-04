using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank_GDI
{
    public partial class Form1 : Form
    {
        Tank tank;//坦克对象
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;//设置窗体背景为黑色
            //在窗体加载的时候创建坦克对象
            tank = new Tank(200, 200, 10, Direction.Up);
            //在paint事件中 调用绘制坦克的方法
            //解决窗体的双缓冲处理
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint, true);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            tank.DrawTank(e.Graphics);//神奇的e
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            tank.GetDirection(e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //使用timer组件不停的刷新屏幕，不停地触发Form1_Paint事件
            this.Invalidate();
        }
    }
}
