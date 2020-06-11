using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名的对象数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //NonameArray是匿名数组
            var NonameArray = new[]
            {
                //匿名对象
                new
                {
                    MainIngredient = "Lamb",
                    Style = "Dhansak",
                    Spiciness = 5
                },
                new
                {
                    MainIngredient = "Lamb",
                    Style = "Dhansak",
                    Spiciness = 5
                },
                new
                {
                    MainIngredient = "Chicken",
                    Style = "Dhansak",
                    Spiciness = 5
                }
            };

            var curry = new
            {
                MainIngredient = "Lamb",
                Style = "Dhansak",
                Spiciness = 5

                
            };

            var cur = new
            {
                a = 5,
                b = 3.2,
                bb = 5
            };
           

            Console.WriteLine("cur.a={0}", cur.a);
            Console.ReadKey();
        }
    }
}
