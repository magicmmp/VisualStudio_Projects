using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs的闭包
{
    class Program
    {

        //执行流程是Main函数调用GetClosureFunction函数，GetClosureFunction返回了委托internalAdd并被立即执行了
        static void Main(string[] args)
        {
            Console.WriteLine(GetClosureFunction()(30));//打印60=30+30，会引用局部变量val的最终值30

            int x = 5;
            Console.WriteLine("x1= {0}", x);
            outParaFunc(out x);
            Console.WriteLine("x2= {0}", x);


            Console.ReadKey();
        }

        static Func<int, int> GetClosureFunction()
        {
            int val = 10;
            Func<int, int> internalAdd = x => x + val;//internalAdd是一个委托

            Console.WriteLine(internalAdd(10));//打印20

            val = 30;
            Console.WriteLine(internalAdd(10));//打印40=10+30

            return internalAdd;//返回了委托
        }


        static void outParaFunc(out int x)
        {
            x = 100;
        }




    }
}
