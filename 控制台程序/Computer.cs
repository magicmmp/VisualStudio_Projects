using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序
{
    public class Computer
    {
        public IUSB USB_1; //模拟插入电脑的U盘
        public void Start()
        {
            Console.WriteLine("电脑开机了");
        }
        public void Stop()
        {
            Console.WriteLine("电脑关机了");
        }
    }
}
