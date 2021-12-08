using System;

namespace _01546_평균
{
    class Program
    {
        static void Main(string[] args)
        {
            int trashValue = int.Parse(Console.ReadLine());
            int[] grade = Array.ConvertAll(Console.ReadLine().Split(" "), value => int.Parse(value));
            int highscore;
            decimal sum = 0;

            Array.Sort(grade); // 점수 정렬 ( 낮은 순 )
            highscore = grade[grade.Length - 1];

            for (int i = 0; i < grade.Length; i++)
                sum += decimal.Multiply(decimal.Divide(grade[i], highscore), 100);

            Console.WriteLine(decimal.Divide(sum, grade.Length));
        }
    }
}
