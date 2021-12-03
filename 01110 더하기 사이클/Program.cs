using System;

namespace _01110_더하기_사이클
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            string startN = N;
            int count = 0;

            while (true)
            {
                if (int.Parse(N) < 10)
                {
                    N = "0" + N;
                }

                string sum = (char.GetNumericValue(N[0]) + char.GetNumericValue(N[1])).ToString();
                N = int.Parse(N[N.Length - 1].ToString() + sum[sum.Length - 1].ToString()).ToString();
                count++;

                if (N == startN)
                    break;
            }

            Console.WriteLine(count);
        }
    }
}
