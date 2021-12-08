using System;
using System.Collections.Generic;

namespace _10818_최소__최대
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(" ");

            int[] arrN = Array.ConvertAll(input, value => int.Parse(value));

            Array.Sort(arrN);

            Console.WriteLine(arrN[0] + " " + arrN[arrN.Length - 1]);
        }
    }
}
