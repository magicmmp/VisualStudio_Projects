using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件和委托_练习
{
    //事件订阅类，当有消息到来时处理一下，将其显示出来
    class Display
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine("Message arrived: {0}", message);
        }

    }
}
