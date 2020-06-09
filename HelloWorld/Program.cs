using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void fun()
        {
            int abc = 50;
            int cd = 20;
            Console.WriteLine("呵呵呵哈哈哈");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("{0} command line arguments were specified:",args.Length);
            string ss = "hehe";
            string[] array = { "字符串1", "张三", "李四" };
            int i = 200;
            fun();
            Debug.Assert(args.Length >= 3, "搞错了!","输入参数少于3个");
            foreach (string arg in args)
                Console.WriteLine(arg);
            Debug.WriteLine(string.Format("参数1：{0}", "hehehh"));
            ss = "haha";
            Console.ReadKey();

            
        }


    }
}
