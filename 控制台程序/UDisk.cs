using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序
{
    //U盘必须实现USB接口功能
    public class UDisk : IUSB
    {
        public string Name { get; set; }
        private string datas;//模拟U盘存放的数据

        public void Read()
        {
            Console.WriteLine("U盘数据："+datas);//读出数据
        }
        public void Write(string dat)
        {
            datas+= dat;//数据写进U盘
        }
    }


}
