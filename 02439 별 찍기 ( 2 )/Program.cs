using System;
using System.Text;

namespace _02439_별_찍기___2__
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    sb.Append(" ");
                }


                for (int x = 1; x <= i; x++)
                {
                    sb.Append("*");
                }

                sb.Append("\n");
            }

            Console.WriteLine(sb);
        }
    }
}