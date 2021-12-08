using System;

namespace _02577_숫자의_개수
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int result = A * B * C;
            string strResult = result.ToString();

            for (int i = 0; i < 10; i++)
            {
                int count = 0;

                foreach (var item in strResult)
                {
                    if (i.ToString().Equals(item.ToString()))
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
