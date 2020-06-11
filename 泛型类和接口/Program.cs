using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using 泛型类和接口.myNamespace;
namespace 泛型类和接口
{

    using myNamespace;


    namespace myNamespace
    {
        class Baseclass
        {
            public int x = 12;
        }

        class Myclass : Baseclass
        {

        }
    }

    
    

    interface MyInterface<T> where T : Baseclass
    {
        bool AttemptToBreed(T animal1, T animal2);
        T OldestInHerd { get; }
    }










    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
