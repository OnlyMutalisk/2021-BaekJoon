using System;
using System.Text;

namespace _02742_기찍_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = N; i >= 1; i--)
            {
                sb.Append(i + "\n");
            }

            Console.WriteLine(sb);
        }
    }
}
