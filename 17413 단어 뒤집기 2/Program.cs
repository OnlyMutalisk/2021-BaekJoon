public class Program
{

    public static void Main()
    {
        // 입력
        string str = Console.ReadLine();

        // char[] 포인터로 변환
        Span<char> span = new Span<char>(str.ToCharArray());

        // 모든 인덱스 기록
        List<int> index = new List<int>();

        for (int i = 0; i < str.Length; i++)
        {
            index.Add(i);
        }

        // 꺽쇠 사이, 공백 제거
        bool flag = false;

        for (int i = 0; i < str.Length; i++)
        {
            if (span[i] == '<')
            {
                flag = true;
            }

            if (flag == true)
            {
                index.Remove(i);
            }

            if (span[i] == '>')
            {
                flag = false;
            }

            if (span[i] == ' ')
            {
                index.Remove(i);
            }
        }

        // 그룹 2 에 타겟 단어만 저장
        List<int> group = new List<int>();
        List<List<int>> group2 = new List<List<int>>();

        foreach (int i in index)
        {
            // 이전에 추가한 index 가 i - 1 이 아니라면 그룹 저장 후 리셋
            if ((group.Count != 0 && group[group.Count - 1] != i - 1) | i == index[index.Count - 1])
            {
                if (i == index[index.Count - 1])
                {
                    group.Add(i);
                }

                group2.Add(new List<int>(group));
                group.Clear();
            }

            group.Add(i);
        }

        // 각 타겟 단어마다의 인덱스를 스왑
        foreach (List<int> list in group2)
        {
            List<int> a = new List<int>(list);
            List<int> b = new List<int>(list);

            b.Reverse();

            for (int i = 0; i < a.Count / 2; i++)
            {
                char temp = span[a[i]];
                span[a[i]] = span[b[i]];
                span[b[i]] = temp;
            }
        }

        Console.WriteLine(span.ToString());
    }
}