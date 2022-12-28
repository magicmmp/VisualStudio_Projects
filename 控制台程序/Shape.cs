using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序
{
    //抽象类
    public abstract class Shape 
    {
        public abstract void Draw();//抽象方法无方法体
    }

    sealed class Circle : Shape
    {
        public override void Draw()//子类实现父类的抽象方法
        {
            Console.WriteLine("画一个圆形");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个长方形");
        }
    }

    
}
