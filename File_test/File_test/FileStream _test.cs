using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_test
{
    internal class FileStream__test
    {
        //FileStream：专门用来操作字节的
        //使用FileStream来读取文本文件
        public static void ReadTest()
        {
            //参数1：要操作的文件的路径
            //参数2：打开文件的方式：写入时可选追加或覆盖
            //参数3：表示对数据要做的操作：读或写
            //1、创建对象
            FileStream fsRead = new FileStream("file_read_test.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //2、创建存放读取字节的缓冲区
            byte[] buffer = new byte[1024 * 1024];
            //3、读取数据，放到缓冲区中
            //参数1：数组buffer，参数2：存放buffer的起始位置，参数3：一次最多读取的字节数
            //返回值r：表示本次读取实际读取到的有效字节数，正常情况大于0
            int r = fsRead.Read(buffer, 0, buffer.Length);
            //4、将字节数组中的数据转换成字符串
            string contents = Encoding.UTF8.GetString(buffer, 0, r);
            Console.WriteLine(contents);
            //GC 流的资源GC不会帮助我们释放，需要我们自己手动的释放
            //如果把创建对象这个过程写在Using()中，using会自动的帮助我们释放资源
            fsRead.Close();
            fsRead.Dispose();
            Console.ReadKey();
        }

        //作用：把source路径的文件复制一份到target路径下
        static void CopyFile(string source, string target)
        {
            //如果把创建对象这个过程写在Using()中，using会自动的帮助我们释放资源
            //创建负责读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //创建负责写入的流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //创建缓冲区的大小  117  2
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //开始读取
                    while (true)
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)//表示读取完了
                        {
                            break;
                        }
                        //读取一次 写入一次
                        fsWrite.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
