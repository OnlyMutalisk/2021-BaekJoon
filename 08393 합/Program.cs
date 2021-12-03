using System;

namespace _08393_합
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= T; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
