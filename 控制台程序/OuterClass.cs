using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序
{
    class OuterClass
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Hello()
        {
            Console.WriteLine("我是外部类OuterClass");
        }

        //定义一个内部类
        public class InnerClass
        {
            public void Show()
            {
                Console.WriteLine("我是嵌套类InnerClass");
            }
        }
    }
}
