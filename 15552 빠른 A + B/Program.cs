using System;
using System.Text;

namespace _15552_빠른_A___B
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string input = string.Empty;
            string[] inputSplit = new string[2];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                input = Console.ReadLine();
                inputSplit = input.Split(" ");

                sb.Append(int.Parse(inputSplit[0]) + int.Parse(inputSplit[1]) + "\n");
            }

            Console.WriteLine(sb);
        }
    }
}
