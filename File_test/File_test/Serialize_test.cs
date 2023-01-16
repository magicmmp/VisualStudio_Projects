using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace File_test
{
    //Serializable标记一个类可以被序列化
    [Serializable]
    class Person
    {
        private string _name;
        private int _age;
        private char _gender;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
    internal class Serialize_test
    {
        //序列化：将对象转换为二进制文件
        //反序列化：将二进制文件转换为对象
        //作用：1传输数据，2状态保持，如保存应用数据。
        public static void Test()
        {
            //序列化：把对象数据保存到文件
            Person person = new Person();
            person.Name = "张三";
            person.Age = 19;
            person.Gender = '男';
            using (FileStream fsWrite = new FileStream("Serialize_test.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //将对象 转换为 二进制
                BinaryFormatter bf = new BinaryFormatter();
                //把对象序列化为二进制
                bf.Serialize(fsWrite, person);
            }
            Console.WriteLine("序列化成功");

            //反序列化：从文件读出对象数据
            Person per;
            using (FileStream fsRead = new FileStream("Serialize_test.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                per = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(per.Name);
            Console.WriteLine(per.Age);
            Console.WriteLine(per.Gender);
            Console.ReadKey();
        }
    }
}
