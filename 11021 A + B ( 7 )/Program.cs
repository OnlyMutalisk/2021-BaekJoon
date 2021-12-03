using System;
using System.Text;

namespace _11021_A___B___7__
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] input = new string[2];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                input = Console.ReadLine().Split(" ");

                sb.Append($"Case #{i + 1}: " + (int.Parse(input[0]) + int.Parse(input[1])) + "\n");
            }

            Console.WriteLine(sb);
        }
    }
}
