using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name");
            string Name=Console.ReadLine();

            Console.Write("Enter your age:");
            string input = Console.ReadLine();
            int age=Convert.ToInt32(input);

            Console.WriteLine($"Hello {Name}, you are {age} years old!");
        }
    }
}
