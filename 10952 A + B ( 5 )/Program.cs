using System;
using System.Text;

namespace _10952_A___B___5__
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[2];
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(" "), value => int.Parse(value));

                if (input[0] == 0 && input[1] == 0)
                {
                    break;
                }

                sb.Append((input[0] + input[1]) + "\n");
            }

            Console.WriteLine(sb);
        }
    }
}
