using System;

namespace Task_1_InsertNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the source number: ");
            string numberSource = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            Console.WriteLine();
            Console.Write("Enter the input number: ");
            string numberIn = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            Console.WriteLine();
            Console.WriteLine("Enter the i:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the j:");
            int j = int.Parse(Console.ReadLine());

            numberSource = ReverseString(numberSource);
            numberIn = ReverseString(numberIn);

            while (true)
            {
                if (numberSource.Length - 1 == j)
                    break;
                numberSource += '0';
            }

            InsertNumber(numberSource.ToCharArray(), numberIn.ToCharArray(), i, j);
        }

        static void InsertNumber(char[] numberSource, char[] numberIn, int i, int j)
        {
            int indexIn = 0;
            for (int indexSource = i; indexSource <= j; indexSource++)
            {
                if (numberSource[indexSource] == '0' && numberIn[indexIn] == '1')
                {
                    numberSource[indexSource] = numberIn[indexIn];
                    indexIn++;
                }
                else
                {
                    indexIn++;
                }

                if (indexIn >= numberIn.Length)
                    break;
            }

            string result = ReverseString(new string(numberSource));
            result = Convert.ToInt32(result, 2).ToString();
            Console.WriteLine(result);
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
