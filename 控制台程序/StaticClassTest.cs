using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序
{
    //静态类
    static class StaticClassTest
    {
        private static string name;//静态字段
        public static string Name //静态字段对应的静态属性
        { 
            get { return name; }
            set { name = value; }
        }
        static StaticClassTest()//静态构造函数
        {
            name = "静态类测试：";
        }
        public static void Hello() //静态方法
        {
            Console.WriteLine("{0} Hello C# ！",name);
        }
    }
}
