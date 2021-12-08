using System;

namespace _02562_최댓값
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[9];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int[] arr = (int[])input.Clone();

            Array.Sort(arr);

            int MAX = arr[arr.Length - 1];
            int index = Array.IndexOf(input, MAX) + 1;

            Console.WriteLine(MAX);
            Console.WriteLine(index);
        }
    }
}
