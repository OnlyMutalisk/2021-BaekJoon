using System.Runtime.InteropServices;
using System.Timers;

public class Program
{
    public static void Main()
    {
        int turn = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();

        for (int i = 0; i < turn; i++)
        {
            string[] str_1 = Console.ReadLine().Split(' ');

            int count = int.Parse(str_1[0]);
            int index_target = int.Parse(str_1[1]);

            string[] str_2 = Console.ReadLine().Split(' ');

            List<Entity> entity = new List<Entity>();

            for (int j = 0; j < str_2.Length; j++)
            {
                entity.Add(new Entity { index = j, priority = int.Parse(str_2[j]) });
            }

            int count_print = 0;

            // 무한 반복
            while (true)
            {
                // top = entity 순회해서 가장 큰 우선순위 저장
                int top = 0;

                foreach (var item in entity)
                {
                    if (item.priority > top)
                    {
                        top = item.priority;
                    }
                }

                // entity[0] >= top 이면
                if (entity[0].priority >= top)
                {
                    // 카운트 ++
                    count_print++;

                    // entity[0].index 가 index_target 이면
                    if (entity[0].index == index_target)
                    {
                        // 카운트를 저장
                        result.Add(count_print);
                        goto TurnEND;
                    }
                    // 아니면
                    else
                    {
                        // entity[0] 을 리스트에서 제거
                        entity.Remove(entity[0]);
                    }
                }
                // 아니면
                else
                {
                    // entity[0] 을 리스트 맨 뒤로 옮김
                    Entity temp = new Entity();
                    temp = entity[0];

                    entity.Remove(entity[0]);
                    entity.Add(temp);
                }
            }

TurnEND:;
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

public struct Entity
{
    public int index;
    public int priority;
}