using System;
using System.Collections.Generic;
using System.Text;

namespace _10871_X_보다_작은_수
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int N = int.Parse(input[0]);
            int X = int.Parse(input[1]);

            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(" "), value => int.Parse(value));
            StringBuilder sb = new StringBuilder();

            foreach (var item in input2)
            {
                if (item < X)
                {
                    sb.Append($"{item} ");
                }
            }

            Console.WriteLine(sb);
        }
    }
}
