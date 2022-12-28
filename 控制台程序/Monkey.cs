using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序
{
    class Monkey
    {
        //1、声明一个静态且私有的当前类的类型的字段
        private static Monkey instance;
        //2、创建私有无参构造方法，确保外部无法实例化这个类
        private Monkey() { }
        //3、创建一个静态方法，用于创建此类的唯一对象
        public static Monkey Instance()
        {
            if (instance == null)
            {
                instance = new Monkey();
            }
            return instance;
        }
    }


    



}
