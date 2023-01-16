using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_test
{
    internal class File_test
    {


        public static void Test1()
        {
            //File类的基本操作： 读写 
            //Create() 创建
            //Delete() 删除
            //Move()   剪切 
            //Copy()   复制
            //Exists() 判断文件是否存在
            //如果文件 不存在 则创建
            if (!File.Exists("1.txt"))
            {
                File.Create("1.txt");
            }
            else////如果文件存在 则删除 再创建一个
            {
                File.Delete("1.txt");
                File.Create("2.txt");
            }
            //对文件进行复制操作
            if (File.Exists("2.txt"))
            {
                //如果文件存在  则复制一个新的到桌面
                //第一个参数是源文件的路径，第二个参数是目标文件的路径
                File.Copy("2.txt", @"C:\Users\pss\Desktop\new.txt");
                //对文件进行剪切操作
                //第一个参数是源文件的路径，第二个参数是目标文件的路径
                File.Move("2.txt", @"C:\Users\pss\Desktop\3.txt");
            }
            
            Console.ReadKey();
        }

        public static void Test2()
        {
            if (!File.Exists("new.txt"))
            {
                File.Create("new.txt");
            }
            //File.ReadAllBytes():由于你操作的是字节，所以可以读取所有的文件
            //使用ReadAllBytes来读取文本文件
            //1、使用ReadAllBytes读取文本文件
            byte[] buffer = File.ReadAllBytes("new.txt");
            //将字节数组中的内容转换成我们认识的字符串
            string contents = Encoding.Default.GetString(buffer);//出现乱码，因为文本的编码是utf8
            Console.WriteLine("new.txt里面的内容："+contents);
            //2、使用ReadAllBytes实现多媒体文件的复制
            if(File.Exists("王力宏-大城小爱.mp4"))
            {
                buffer = File.ReadAllBytes("王力宏-大城小爱.mp4");
                File.WriteAllBytes(@"C:\Users\pss\Desktop\王力宏-大城小爱2.mp4", buffer);
                Console.WriteLine("复制成功！！！");
            }
            

            //3、不需要操作每行的数据，仅仅是读取出来查看,使用ReadAllText
            //文本文件：如果拖到txt中还能看得懂，那么就是文本文件。
            //获得文本文件中的字符串 UTF-8 Encoding.Default获取当前操作系统默认的编码
            string str = File.ReadAllText("new.txt", Encoding.UTF8);
            Console.WriteLine(str);

            //4、如果需要对每行的数据进行操作，使用File.ReadAllLines():
            string[] lines = File.ReadAllLines("new.txt", Encoding.UTF8);
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }
            //使用File来写入文件
            //5、使用WriteAllBytes()来写入文本文件
            contents = "老毕吃了一顿饭，唱了一首歌，结果火了";
            //将字符串转换成字节数组
            buffer = Encoding.Default.GetBytes(contents);
            File.WriteAllBytes("new.txt", buffer);
            Console.WriteLine("写入成功");

            //6、使用WriteAllLines()来写入数据，覆盖写入，会将之前的数据全部覆盖
            File.WriteAllLines("new.txt", new string[] { "a" });
            Console.WriteLine("写入成功");
            //覆盖写入
            File.WriteAllText("new.txt", "呵呵");
            Console.ReadKey();
        }

    }

}
