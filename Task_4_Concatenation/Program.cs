using System;
using System.Linq;

namespace Task_4_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string result = new string(String.Concat(s1, s2).Distinct().ToArray());
            Console.WriteLine(result);
        }
    }
}
