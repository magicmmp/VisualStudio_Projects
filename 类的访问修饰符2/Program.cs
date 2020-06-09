using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace 类和接口的继承_练习
{
    class MyBaseClass
    {
        public int index;

    }

    class MyBaseClass2
    {
        public int index;

    }
}

namespace 类的访问修饰符2
{
    class Program: 类和接口的继承_练习.MyBaseClass2
    {
        static void Main(string[] args)
        {
            MyExternalClass myExternalClass = new MyExternalClass();
            myExternalClass.i = 10;
            Console.WriteLine("i={0}",myExternalClass.i);
            Console.ReadKey();
        }
    }
}
