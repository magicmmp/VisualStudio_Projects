using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace 事件和委托_练习
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            //初始化了 Connection 和 Display 类的实例，把它们关联起来，开始执
            //行任务
            Connection myConnection = new Connection();
         
            Display myDisplay = new Display();
            myConnection.MessageArrived +=
            new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            Console.ReadKey();
        }


    }
}
