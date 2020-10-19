using System;
using System.Collections.Generic;

namespace Task_5_FindNextBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            var numberList = new List<char>();
            foreach (var elem in number)
                numberList.Add(elem);

            foreach (var elem in numberList)
                Console.Write(elem + " ");

            var result = new List<char>();
            int index = 0;

            Console.WriteLine();

            for (int i = numberList.Count - 1; i > 0; i--)
            {
                if (numberList[i] > numberList[i - 1])
                {
                    index = i;
                    //Swipe two elements
                    char temp = numberList[i];
                    numberList[i] = numberList[i - 1];
                    numberList[i - 1] = temp;

                    break;
                }
            }

            char[] ch = new char[numberList.Count - index];
            int ind = 0;
            for (int i = index; i < numberList.Count; i++)
            {
                ch[ind] = numberList[i];
                ind++;
            }

            Array.Sort(ch);
            ind = 0;
            for (int i = index; i < numberList.Count; i++)
            {
                numberList[i] = ch[ind];
                ind++;
            }


            foreach (var elem in numberList)
                Console.Write(elem + " ");
        }

        private static void Swap(List<char> numberList, int i)
        {
            char temp = numberList[i];
            numberList[i] = numberList[i + 1];
            numberList[i + 1] = temp;
        }

        private static void ChangeList(List<char> numberList, int index)
        {

        }
    }
}
