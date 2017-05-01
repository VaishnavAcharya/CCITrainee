using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputDay1Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name :");
            var name = Console.ReadLine();
            Console.WriteLine("\nYour name is :" + name);
            Console.ReadKey();
        }
    }
}
