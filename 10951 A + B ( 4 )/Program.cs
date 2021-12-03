using System;
using System.Collections.Generic;
using System.Text;

namespace _10951_A___B___4__
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int[] refinedInput = Array.ConvertAll(input.Split(" "), value => int.Parse(value));

                Console.WriteLine((refinedInput[0] + refinedInput[1]));
            }
        }
    }
}
