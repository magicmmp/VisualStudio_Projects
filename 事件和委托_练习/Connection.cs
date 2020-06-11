using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace 事件和委托_练习
{
    /**
     * 假定一个即时消息传送(instant messaging)应用程序创建的对象表示一个远程用户的连接。当接收到通过该连接从
     * 远程用户传送来的信息时，这个连接对象会引发一个事件
     */

    public delegate void MessageHandler(string messageText);
    public class Connection
    {
        public event MessageHandler MessageArrived;
        private Timer pollTimer;
        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }
        public void Connect()
        {
            pollTimer.Start();
        }
        public void Disconnect()
        {
            pollTimer.Stop();
        }
        private static Random random = new Random();
        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Checking for new messages.");

            if ((random.Next(9) == 0) && (MessageArrived != null))
            {
                MessageArrived("Hello Mum!");
            }
        }
    }
}
