using System;
using System.Text;

namespace _11022_A___B___8__
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

                sb.Append(String.Format("Case #{0}: {1} + {2} = {3}\n", i + 1, input[0], input[1], (int.Parse(input[0]) + int.Parse(input[1]))));
            }

            Console.WriteLine(sb);
        }
    }
}
