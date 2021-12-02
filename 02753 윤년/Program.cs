using System;

namespace _02753_윤년
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }

            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
