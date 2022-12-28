using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序
{
    //USB是一种通信协议的接口规范。U盘、电脑等需要实现USB接口的功能
   public interface IUSB
    {
        string Name { get; set; }//接口可以使用自动属性
        void Read();//USB通信具有的功能：读
        void Write(string dat);
    }
}
