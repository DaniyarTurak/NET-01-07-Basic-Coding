using System;

namespace Task_6_FilterDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the targe number: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array: ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            FilterDigit(arr, target);
        }

        private static bool DivideNumber(int x, int target)
        {
            while (x > 0)
            {
                int temp = x % 10;
                x /= 10;
                if (temp == target)
                    return true;
            }
            return false;
        }

        private static void FilterDigit(int[] arr, int target)
        {
            foreach (var item in arr)
            {
                bool check = DivideNumber(item, target);
                if (check)
                    Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
