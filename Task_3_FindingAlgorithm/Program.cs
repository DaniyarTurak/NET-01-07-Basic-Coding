using System;

namespace Task_3_FindingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter elements of arrays: ");
            Console.WriteLine();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(FindIndex(arr));
        }

        static int FindIndex(int[] arr)
        {
            int l = 0;
            int r = arr.Length - 1;
            int mid = l + (r - l) / 2;
            int sumLeft = 0;
            int sumRight = 0;
            // чтобы ограничить поиск
            int count = 0;

            while (mid > l && mid < r)
            {
                for (int i = l; i < mid; i++)
                {
                    sumLeft += arr[i];
                }
                for (int i = mid + 1; i <= r; i++)
                {
                    sumRight += arr[i];
                }

                if (sumLeft == sumRight)
                    return mid;
                else if (sumLeft > sumRight)
                {
                    mid -= 1;
                    count++;
                }
                else
                {
                    mid += 1;
                    count--;
                }

                // если mid  раз сдвинулся в лево, потом в право то значит нет смысла искать дальше
                if (count == 0)
                    break;

                sumLeft = 0;
                sumRight = 0;
            }
            return -1;
        }
    }
}
