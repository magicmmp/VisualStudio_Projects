using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace File_test
{
    public class Md5_test
    {
        //MD5是不可逆的
        //作用：把字符串str进行MD5加密，返回加密后的16进制字符串
        public static string GetMD5(string str)
        {
            //1、获得MD5对象
            MD5 md5 = MD5.Create();
            //2、将要加密的字符串转换成字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //3、加密 返回加密好的字节数组
            byte[] md5Buffer = md5.ComputeHash(buffer);
            //将加密好的字节数组再次转换成字符串
            //return Encoding.Default.GetString(md5Buffer);

            //字节数组---->字符串  ToString()  GetString()
            //12 21 13 
            string res = string.Empty;//string res="";
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                //十进制---->十六进制
                res += md5Buffer[i].ToString("x2");//输出为16进制
            }
            return res;
        }
        public static void Test()
        {
            string md5Str = GetMD5("123");
            //输出：202cb962ac59075b964b07152d234b70
            Console.WriteLine(md5Str);
            Console.ReadKey();
            //作业：对一个文件进行加密
        }
    }
}
