using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_test
{
    internal class Path_test
    {

        public static void Test()
        {
            string path = @"C:\Users\SpringRain\Desktop\1.txt";

            //Path类帮助我们操作文件或者文件夹的路径
            //获得文件名，包含扩展名
            Console.WriteLine(Path.GetFileName(path));
            //获得文件名但是不包含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            //获得文件所在的文件夹的路径
            Console.WriteLine(Path.GetDirectoryName(path));
            //改变文件的扩展名
            Console.WriteLine(Path.ChangeExtension(path, ".jpg"));
            //将多个路径连接成一个路径  注意 "\"要放到前一个路径的结尾，而不能放到后一个路径的开头
            Console.WriteLine(Path.Combine(@"c:\a\", @"b\c\", "d.txt"));
            //路径：绝对路径 ,可以直接在电脑中找到的路径
            //相对路径：是文件相对于我应用程序的路径
            string path2 = "1.txt";
            //通过相对路径来获得绝对路径
            //C:\Users\SpringRain\Desktop\0615.Net基础班第十二天\09Path\bin\Debug\1.txt
            //C:\Users\SpringRain\Desktop\0615.Net基础班第十二天\09Path\bin\Debug\1.txt
            Console.WriteLine(Path.GetFullPath(path2));

        }
    }
}
