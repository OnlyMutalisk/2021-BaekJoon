using System;

namespace _02884_알람_시계
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrTime = Console.ReadLine().Split(" ");
            int H = int.Parse(arrTime[0]);
            int M = int.Parse(arrTime[1]);

            if (M < 45)
            {
                if (H == 0) { H = 23; }
                else { H -= 1; }

                M = 60 + M - 45;
            }
            else
            {
                M -= 45;
            }

            Console.WriteLine(H + " " + M);
        }
    }
}
