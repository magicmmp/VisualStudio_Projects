using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace File_test
{
    internal class Directory_test
    {
        public static void Test()
        {
            //创建 判断是否存在 删除 复制 剪切

            if (!Directory.Exists("directory_test"))
            {
                Directory.CreateDirectory("directory_test");
            }
            else
            {
                //如果存在 则删除 再创建
                //如果要删除的文件夹中存在数据，则默认不允许删除
                //参数2为true表示强制删除文件夹，即使不是空文件夹
                Directory.Delete("directory_test", true);
                Directory.CreateDirectory("directory_test");
            }
            Console.WriteLine("创建成功");

            //要求 必须在同一个磁盘下移动文件夹
            Directory.Move(@"C:\Users\pss\Desktop\w", @"c:\a");
            Console.WriteLine("移动成功");

            //获得指定文件夹下所有文件的全路径
            //第二个参数对筛选出来的结果集进行筛选
            string[] files = Directory.GetFiles(@"C:\Users\Public", "*.exe");
            foreach (string item in files)
            {
                Console.WriteLine(item);
            }

            string[] dirs = Directory.GetDirectories(@"c:\");
            foreach (string item in dirs)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
