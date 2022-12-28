using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合和泛型练习
{
    public class Computer : IEquatable<Computer>, IComparable<Computer>
    {
        public int sn;//电脑的序列号，每台电脑都不同如 PF0ZZ6A8
        public int price;//价格
        public string name;//电脑品牌名称
        //有参构造方法
        public Computer(int sn, int price, string name)
        {
            this.sn = sn;
            this.price = price;
            this.name = name;
        }

        public override string ToString()//重写ToString方法
        {
            return "名称="+name+",价格="+price+",SN="+sn;
        }
        //按照电脑价格进行大小排序
        // 这里使用整数默认的CompareTo方法
        public int CompareTo(Computer other)
        {
            return this.price.CompareTo(other.price);//整数Int32也实现了比较接口CompareTo
        }
        //通过比较序列号判断是否同一台电脑
        bool IEquatable<Computer>.Equals(Computer other)//实现接口方法
        {
            if (other == null) return false;
            return (this.sn==other.sn);
        }
        public override bool Equals(object obj)//重写Object的相等比较方法
        {
            if (obj == null) return false;
            Computer compu = obj as Computer;
            if (compu == null) return false;
            else return Equals(compu);
        }

        public static void Test()//排序测试
        {
            List<Computer> lists = new List<Computer>();
            Random r = new Random();
            for (int i=0;i<10;i++)
            {
                lists.Add(new Computer(r.Next(),r.Next(3000)+2000,"Acer-"+i));
            }

            foreach(Computer c in lists)
            {
                Console.WriteLine(c);
            }
            lists.Sort();
            Console.WriteLine("排序后：");

            foreach (Computer c in lists)
            {
                Console.WriteLine(c);
            }
        }
    }
}
