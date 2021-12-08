using System;
using System.Collections.Generic;
using System.Linq;

namespace _03052_나머지
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listRemainder = new List<int>();
                
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int remainder = a % 42;

                listRemainder.Add(remainder);
            }

            listRemainder = listRemainder.Distinct().ToList();

            Console.WriteLine(listRemainder.Count);
        }
    }
}
