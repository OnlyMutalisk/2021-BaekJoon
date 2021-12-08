using System;
using System.Text;

namespace _04344_평균은_넘겠지
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < testCase; i++)
            {
                string[] strInput = Console.ReadLine().Split(" ");
                decimal[] input = Array.ConvertAll(strInput, value => decimal.Parse(value));
                decimal sum = 0;
                decimal average;
                int highScore = 0;
                decimal percent = 0;

                for (int j = 1; j < input.Length; j++)
                {
                    sum += input[j];
                }

                average = decimal.Divide(sum, input.Length - 1);

                for (int k = 1; k < input.Length; k++)
                {
                    if (input[k] > average)
                    {
                        highScore++;
                    }
                }

                percent = decimal.Divide(highScore, input.Length - 1) * 100m;
                percent = Math.Round(percent, 3);
                string strPercent = string.Format("{0:N3}", percent);

                sb.Append(strPercent + "%\n");
            }

            Console.WriteLine(sb);
        }
    }
}
