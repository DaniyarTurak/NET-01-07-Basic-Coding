using System;

namespace Task_2_RecursiveMaxElementSearchAlgorithm
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
            int maxNumber = arr[0];
            int index = 0;
            Console.WriteLine(FindMax(arr, maxNumber, index));
        }

        static int FindMax(int[] arr, int maxi, int index)
        {
            if (index == arr.Length - 1)
                return maxi;

            if (arr[index] > maxi)
                return FindMax(arr, arr[index], index + 1);
            return FindMax(arr, maxi, index + 1);
        }
    }
}
