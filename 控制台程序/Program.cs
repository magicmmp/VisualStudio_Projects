using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 控制台程序
{
    //定义一个动物类
    public class Animal
    {
        private string name; //字段name，其实就是一个变量
        private int age;//动物年龄

        //如果存在有参构造方法，那么无参构造方法不再自动生成，需要手动创建
        public Animal() { }//无参构造方法

        public Animal(string name,int age) //有参构造方法
        { 
            this.name = name;
            this.age = age;
        }

        //C#通过属性对类的字段进行访问操作
        //属性修饰符用public，因为要给外界访问
        //属性返回类型和字段类型相同
        //属性名和对应字段名相同，但首字母大写
        public int Age 
        { 
            get { return age; } //取值
            set 
            { //对属性的赋值会传递到value变量
                if(value>100 || value<0)//对不合理的赋值进行处理
                    age = 18;
                else
                    age = value; 
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Walk()
        {
            Console.WriteLine("我可以走路");
        }
    }

    //子类只能继承和访问父类public修饰的字段、属性和方法
    //具体的动物：老虎
    public class Cat : Animal
    {
        private int nRats;//猫今天抓到老鼠数量
        public Cat() { }
        //调用父类构造方法base()初始化父类的字段数据
        public Cat(string name, int age,int nRats) :base(name,age)
        { 
            this.nRats = nRats;//子类的字段数据在子类构造方法初始化
        }
        //猫的技能：抓老鼠
        public void ZhuaLaoShu()
        {
            Console.WriteLine("我{1}今天抓了{0}只老鼠", nRats,Name);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("胖橘", 2, 2);
            cat.Walk();//猫是动物，继承动物共有的能力：走路
            cat.ZhuaLaoShu();//猫特有的能力：抓老鼠

            // 创建一个 List<Shape> 对象，并向该对象添加 Circle和 Rectangle
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Circle()
            };

            // 使用 foreach 循环对该列表的派生类进行循环访问，并对其中的每个 Shape 对象调用 Draw 方法
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            UDisk uDisk = new UDisk();//U盘对象
            Computer computer = new Computer();
            computer.Start();
            computer.USB_1 = uDisk;//模拟U盘插入电脑
            computer.USB_1.Write("一些数据");//电脑对U盘写入数据
            computer.USB_1.Read();//电脑读出U盘数据
            computer.Stop();

            StaticClassTest.Hello();


            Console.ReadKey();

        }
    }
}
