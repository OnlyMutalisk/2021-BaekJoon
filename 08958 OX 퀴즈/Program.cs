using System;

namespace _08958_OX_퀴즈
{
    class Program
    {
        static void Main(string[] args)
        {
            int trashValue = int.Parse(Console.ReadLine());
            int[] arrScore = new int[trashValue];

            for (int i = 0; i < trashValue; i++)
            {
                string answer = Console.ReadLine();

                int count = 0;
                int score = 0;

                foreach (var item in answer)
                {
                    if (item.ToString().Equals("O"))
                    {
                        count++;
                        score += count;
                    }
                    else
                    {
                        count = 0;
                    }
                }

                arrScore[i] = score;
            }

            foreach (var item in arrScore)
            {
                Console.WriteLine(item);
            }
        }
    }
}
