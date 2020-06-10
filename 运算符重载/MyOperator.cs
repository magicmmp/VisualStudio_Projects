using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符重载
{
    class MyOperator
    {
        static void Main(string[] args)
        {
            Num n1 = new Num();
            Num n2 = new Num();
            n1.value = 2;
            n2.value = 6;
            Num n = n1+n2;
            Console.WriteLine("n.value= {0}", n.value);
            Console.ReadKey();
        }
    }

    class Num
    {
        public int value;

        public static Num operator +(Num n1,Num n2) //使对象可以直接相加
        {
            Num returnObj = new Num();
            returnObj.value = n1.value + n2.value;
            return returnObj;
        }
    }





}
