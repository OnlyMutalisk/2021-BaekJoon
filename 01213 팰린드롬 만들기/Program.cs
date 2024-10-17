using System.Text;

public class Program
{
    public static void Main()
    {
        List<char> chars = new List<char>();
        StringBuilder sb = new StringBuilder();

        string str = Console.ReadLine();

        // N <= 1 이면 그냥 출력
        if (str.Length <= 1)
        {
            Console.WriteLine(str);
            return;
        }

        // 입력 문자열을 chars 혹은 sb 로 삽입
        for (int i = 0; i < str.Length; i++)
        {
            if (chars.Contains(str[i]) == false)
            {
                chars.Add(str[i]);
            }
            else
            {
                chars.Remove(str[i]);
                sb.Append(str[i]);
            }
        }

        // 짝이 없는 녀석이 2개 이상이면 Sorry
        if (chars.Count >= 2)
        {
            Console.WriteLine("I'm Sorry Hansoo");
            return;
        }

        // 아니면 팰린드롬 출력
        // front
        string front = sb.ToString();
        char[] temp = front.ToCharArray();
        Array.Sort(temp);
        front = new string(temp);

        // back
        Array.Reverse(temp);
        string back = new string(temp);

        if (chars.Count == 1)
        {
            Console.WriteLine(front + chars[0] + back);
        }
        else
        {
            Console.WriteLine(front + back);
        }
    }
}