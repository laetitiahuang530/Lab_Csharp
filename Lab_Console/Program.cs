using Lab_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入姓名: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello! C#! " + Name );
            Console.ReadKey();
            MyClass mc = new MyClass();
            mc.Method03();
        }
    }
}
