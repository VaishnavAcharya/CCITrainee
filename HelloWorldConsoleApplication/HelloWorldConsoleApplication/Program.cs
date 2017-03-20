using System;

namespace HelloWorldConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            ConsoleKeyInfo keyinfo = Console.ReadKey(false);
            Console.WriteLine(keyinfo.KeyChar);
            Console.ReadKey();
        }
    }
}
