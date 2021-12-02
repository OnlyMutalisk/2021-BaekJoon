using System;
using System.Collections.Generic;

namespace _01330_두_수_비교하기
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] arrNumber = a.Split(" ");

            int A = int.Parse(arrNumber[0]);
            int B = int.Parse(arrNumber[1]);

            if (A > B)
            {
                Console.WriteLine(">");
            }
            else if (A < B)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
