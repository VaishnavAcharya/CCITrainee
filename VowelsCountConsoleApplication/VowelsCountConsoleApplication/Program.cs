using System;


namespace VowelsConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = GetInputData();
            VowelCountDisplay(inputData);

        }

        private static string GetInputData()
        {
            Console.WriteLine("Enter data whose vowel count is to be found:");
            return Console.ReadLine();
        }

        private static int GetVowelsCount(string name)
        {
            int nameLength, vowelsCount = 0;
            nameLength = name.Length;
            for (int i = 0; i < nameLength; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                    vowelsCount = vowelsCount + 1;
            }

            return vowelsCount;
        }

        private static void VowelCountDisplay(string inputData)
        {
            Console.WriteLine("The Number of Vowels in the data is :" + GetVowelsCount(inputData));
            Console.ReadKey();
        }


    }
}

