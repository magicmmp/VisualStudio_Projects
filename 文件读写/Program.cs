using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件读写
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            try
            {
                FileStream aFile = new FileStream("Log.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(aFile);
                bool truth = true;
                // Write data to file.
                sw.WriteLine("Hello to you.");
                sw.WriteLine("It is now {0} and things are looking good.",
                DateTime.Now.ToLongDateString());
                sw.Write("More than that,");
                sw.Write(" it’s {0} that C# is fun.", truth);
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
            */

            string line;

            try
            {
                FileStream aFile = new FileStream("Log.txt", FileMode.Open);

                StreamReader sr = new StreamReader(aFile);

                /**
                 
                line = sr.ReadLine();
                // Read data in line by line.
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                */
                
                int nChar;
                nChar = sr.Read();
                while (nChar != -1)
                {
                    Console.Write(Convert.ToChar(nChar));
                    nChar = sr.Read();
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                return;
            }
            Console.ReadKey();














        }
    }
}
