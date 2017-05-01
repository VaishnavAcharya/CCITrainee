using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastManStanding
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n,lastManStanding;
            //Console.WriteLine("Input the number of people standing:");
            //n = Convert.ToInt32(Console.ReadLine());
            //if (n == 1 || n == 2 || n % 4 == 0)
            //    lastManStanding = 1;
            //else
            //    lastManStanding = 0;
            //Console.WriteLine($"Last Man standing is :{lastManStanding}");
            //Console.ReadKey();
            int n;
            List<int> numPeople = new List<int> { };
            Console.WriteLine("Input the number of people standing :");
            n = Convert.ToInt16(Console.ReadLine());
            for(int i=1;i<=n; i++)
            {
                numPeople.Add(i);
            }
            foreach (var num in numPeople)
            { Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
