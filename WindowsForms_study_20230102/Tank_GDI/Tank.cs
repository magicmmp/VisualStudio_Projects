using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tank_GDI.Properties;

namespace Tank_GDI
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class Tank
    {
        //方向
        private Direction _dir;
        //方向的属性
        internal Direction Dir
        {
            get { return _dir; }
            set { _dir = value; }
        }
        private int _speed;//速度
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        //四张不同方向的坦克图片
        private Image[] imgs = {Resources.p1tankU,Resources.p1tankD,
                                Resources.p1tankL,Resources.p1tankR};
        //坦克x、y坐标
        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Tank(int x, int y, int speed, Direction dir)
        {
            this.X = x;
            this.Y = y;
            this.Speed = speed;
            this.Dir = dir;
        }
        //坦克不停地将自己绘制到屏幕上
        public void DrawTank(Graphics g)
        {
            //根据坦克当前的方向绘制坦克
            switch (this.Dir)
            {
                case Direction.Up:
                    g.DrawImage(imgs[0], this.X, this.Y);
                    break;
                case Direction.Down:
                    g.DrawImage(imgs[1], this.X, this.Y);
                    break;
                case Direction.Left:
                    g.DrawImage(imgs[2], this.X, this.Y);
                    break;
                case Direction.Right:
                    g.DrawImage(imgs[3], this.X, this.Y);
                    break;
            }
        }
        //根据用户按下的键 更新坦克移动的方向和位置
        //注意：按键事件参数也传给了本方法，以获得按键
        public void GetDirection(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    this.Dir = Direction.Up;
                    break;
                case Keys.S:
                    this.Dir = Direction.Down;
                    break;
                case Keys.A:
                    this.Dir = Direction.Left;
                    break;
                case Keys.D:
                    this.Dir = Direction.Right;
                    break;
            }
            Move();//移动坦克
        }
        //更新坦克移动的位置
        public void Move()
        {
            switch (this.Dir)
            {
                case Direction.Up:
                    this.Y -= this.Speed;
                    break;
                case Direction.Down:
                    this.Y += this.Speed;
                    break;
                case Direction.Left:
                    this.X -= this.Speed;
                    break;
                case Direction.Right:
                    this.X += this.Speed;
                    break;
            }
        }
    }
}
