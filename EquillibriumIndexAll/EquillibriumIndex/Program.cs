using System;
using System.Collections.Generic;


namespace EquillibriumIndex
{
    class Solution
    {
        static void Main(string[] args)
        {

            int[] array = GetInputArray();

            
            DispayResult(GetEquillibriumIndices(array));

        }

       

        private static int[] GetInputArray()
        {
            int n;
            int[] array;
            Console.WriteLine("Please enter the array size");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("Please enter the array elements");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        private static List<int> GetEquillibriumIndices(int[] array)
        {
            List<int> indices = new List<int> { };
            int sumLHS = 0, sumRHS = 0, sum = 0;
            //find the sum of the array
            for(int p=0; p<array.Length;p++)
            {
                sum += array[p];
            }

            for (int p = 0; p <array.Length; p++)
            {
                sumRHS = sum - sumLHS - array[p];
                if (sumRHS == sumLHS)
                    indices.Add(p);
                sumLHS += array[p];
            }
            return indices;

        }

        private static void DispayResult(List<int> indices)
        {
            if (indices.Count != 0)
            {
                Console.WriteLine("equillibrium indices are:");
                foreach(var index in indices)
                {
                    Console.WriteLine(index);
                }
            }
            else
                Console.WriteLine("No indices found!!");
            Console.ReadKey();
        }


    }
}
