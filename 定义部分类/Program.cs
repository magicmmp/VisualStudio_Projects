using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 定义部分类
{
    
    class Program
    {
        static void Main(string[] args)
        {
            PartiaClass partia = new PartiaClass();
            partia.i = 10;
            partia.j = 112;

            Console.WriteLine("partia.i = {0}; partia.j = {1}",partia.i, partia.j);


            Console.ReadKey();
      
        }
    }




}
