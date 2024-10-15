public class Program
{
    public static void Main()
    {
        int N;
        int Ave;
        int Mid;
        int Many;
        int Rang;

        Program p = new Program();

        N = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        for (int i = 0; i < N; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        list.Sort();
        Ave = p.Average(ref list);
        Mid = list[list.Count / 2];
        Many = p.ManyNumber(ref list);
        Rang = list[list.Count - 1] - list[0];

        Console.WriteLine(Ave);
        Console.WriteLine(Mid);
        Console.WriteLine(Many);
        Console.WriteLine(Rang);
    }

    public int Average(ref List<int> list)
    {
        return (int)Math.Round(((float)list.Sum() / (float)list.Count()), 0);
    }

    public int ManyNumber(ref List<int> list)
    {
        int many = 0;
        int temp = 4001;
        int count = 0;
        int count_many = 0;
        List<int> list_many = new List<int>();

        foreach (int num in list)
        {
            if (list.Count == 1)
            {
                return list[0];
            }

            if (num == temp)
            {
                count++;
            }
            else
            {
                count = 0;
                temp = num;
            }

            if (count > count_many)
            {
                many = num;
                count_many = count;
                list_many.Clear();
                list_many.Add(num);
            }
            else if (count == count_many)
            {
                list_many.Add(num);
            }

        }

        if (list_many.Count >= 2)
        {
            list_many.Sort();
            many = list_many[1];
        }

        return many;
    }
}