using System.Linq;

public class Program
{
    public static void Main()
    {
        int count_query = int.Parse(Console.ReadLine());
        string nums = "123456789";

        // 모든 조합 리스트 생성
        List<string> combinations = Enumerable.Range(0, nums.Length)
                                        .SelectMany(a => Enumerable.Range(a + 1, nums.Length - (a + 1))
                                            .SelectMany(b => Enumerable.Range(b + 1, nums.Length - (b + 1))
                                                .Select(c => "" + nums[a] + nums[b] + nums[c])))
                                    .ToList();

        // 쿼리 추가
        List<(string num, int strike, int ball)> list_query = new List<(string, int, int)>();

        for (int i = 0; i < count_query; i++)
        {
            string[] query = Console.ReadLine().Split(' ');
            string num = query[0];
            int strike = int.Parse(query[1]);
            int ball = int.Parse(query[2]);

            list_query.Add((num, strike, ball));
        }

        // 유망한 원소 찾기
        List<string> promising = new List<string>();
        Program p = new Program();

        foreach (string str in combinations)
        {
            bool isPromising = true;

            // 모든 쿼리를 만족하는지 체크
            foreach (var query in list_query)
            {
                isPromising = p.Check(str, query);
                if (isPromising == false) break;
            }

            // 모든 쿼리를 만족하면, 유망한 원소 리스트에 추가
            if (isPromising == true)
            {
                promising.Add(str);
            }
        }

        // 유망한 원소 개수 출력
        Console.WriteLine(promising.Count);
    }

    // 쿼리가 올바른지를 반환
    public bool Check(string str, (string num, int strike, int ball) query)
    {
        int strike = 0;
        int ball = 0;

        // num[i] 가 query 에 Contains 하면 ball
        foreach (var a in query.num)
        {
            if (str.Contains(a))
            {
                // 자릿수까지 같으면 strike++
                if (str.IndexOf(a) == query.num.IndexOf(a))
                {
                    strike++;
                }
                // 자릿수는 다르면 ball++
                else
                {
                    ball++;
                }
            }
        }

        return (strike == query.strike) && (ball == query.ball);
    }
}