using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        private int tmp = 666;//私有成员变量

        static void Main(string[] args)
        {
            /* 我的第一个 C# 程序*/
            Program pp = new Program();
            Console.WriteLine("tmp={0}", pp.tmp);//可以访问tmp
            Console.ReadKey();
        }

        public int GetTmp()
        {
            return tmp;
        }

    }
}
