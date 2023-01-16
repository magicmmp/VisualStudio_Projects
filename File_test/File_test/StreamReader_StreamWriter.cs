using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace File_test
{
    internal class StreamReader_StreamWriter
    {
        //使用StreamReader来读取文本数据（而不是二进制字节数据）
        public static void StreamReader_test()
        {
            using (StreamReader sr = new StreamReader("file_read_test.txt", Encoding.UTF8))
            {
                //ReadLine每次读取并返回一行数据
                while (!sr.EndOfStream)//只要没读完，就一直读取
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadKey();
        }

        //StreamWriter向文件写入文字字符串，而不是二进制字节数据。
        public static void StreamWriter_test()
        {
            //第二个参数表示：是否追加写入，而不是覆盖之前的内容
            using (StreamWriter sw = new StreamWriter("file_write_test.txt", true))//第二个参数表示是否追加到文件
            {
                for(int i=0;i<10;i++)
                    sw.WriteLine("StreamWriter写入：第{0}行",i);
            }
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }


    }
}
