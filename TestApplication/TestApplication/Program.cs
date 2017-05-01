using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)

        { 
            char cr = '\u0011';
             int chrvalue= (int)cr;
            Console.WriteLine(chrvalue);
            Console.ReadKey();
        }
    }
}
