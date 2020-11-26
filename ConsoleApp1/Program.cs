using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            //int age;
            Console.WriteLine("Hello world!");
            Console.ReadKey();
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //age = Console.Read();
            Console.WriteLine("Hello " + name /*+ " " + age*/);
            Console.ReadKey();
        }
    }
}
