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
        public const int MyInt = 17;
        private const string ss = "heheh";
        public static int AutoVal
        {
            get;set;
        }
        static void Main(string[] args)
        {
            AutoVal = 12;
            Console.WriteLine("MyInt= {0,-8:X4}, ss={1}, AutoVal={2}", MyInt,ss,AutoVal);
           
            Console.ReadKey();

            
        }
    }

    class BaseClass
    {
        public int i;
        public int getInt()
        {
            return i;
        }
    }

    class DriveClass:BaseClass,Imyhh
    {
        public int j;
    }

    interface Imyhh
    {

    }

}
