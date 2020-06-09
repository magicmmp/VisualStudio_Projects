using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SerialPortConnection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            string s = "在循环外";
            for(int i=0;i<1;i++)
            {
                s = "在循环内";
                Console.WriteLine(s);
            }
            Console.WriteLine(s);


            Application.Run(new Form1());
        }
    }
}
