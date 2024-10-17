using System;

public class Program
{
    public static void Main()
    {
        int bb = '\n';
        int bbb = '\n';

        // 행렬 크기 받기
        string[] input = Console.ReadLine().Split(' ');
        int i = int.Parse(input[0]);
        int j = int.Parse(input[1]);

        // 0 값 존재 시 0 출력 후 리턴
        if (i == 0 | j == 0)
        {
            Console.WriteLine(0);
            return;
        }

        int[,] matrix = new int[i, j];

        // 행렬에 데이터 삽입
        for (int a = 0; a < i; a++)
        {
            for (int b = 0; b < j; b++)
            {
                int data = -1;

                while (data < 0)
                {
                    data = Console.Read() - '0';
                }

                matrix[a, b] = data;
            }
        }

        // 가장 큰 정사각형 부터 시작
        for (int edge = Math.Min(i, j) - 1; edge >= 0; edge--)
        {
            // 모든 [i, j] 에 대해 수행
            for (int a = 0; a <= i - edge - 1; a++)
            {
                for (int b = 0; b <= j - edge - 1; b++)
                {
                    // 네 꼭짓점 값이 모두 같으면 출력 후 프로그램 종료
                    if (matrix[a, b] == matrix[a + edge, b] &&
                       matrix[a, b] == matrix[a, b + edge] &&
                       matrix[a, b] == matrix[a + edge, b + edge])
                    {
                        Console.WriteLine((edge + 1) * (edge + 1));
                        return;
                    }
                }
            }
        }
    }
}