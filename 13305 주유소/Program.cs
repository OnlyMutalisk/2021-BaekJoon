using System.Security.Cryptography.X509Certificates;

public class Car
{
    public int fee = 0;

    public City currentCity;
    public Way nextWay;

    public void buy(int L, int price_cheapest)
    {
        fee += price_cheapest * L;
    }
}

public struct City
{
    public int index;
    public int price;
}

public struct Way
{
    public int index;
    public int length;
}

public class Program
{
    public static void Main()
    {
        Console.ReadLine();

        string str = Console.ReadLine();
        string[] str_way = str.Split(' ');
        List<int> way_length = new List<int>();

        foreach (var way in str_way)
        {
            way_length.Add(int.Parse(way));
        }

        str = Console.ReadLine();
        string[] str_city = str.Split(' ');
        List<int> city_price = new List<int>();

        foreach (var city in str_city)
        {
            city_price.Add(int.Parse(city));
        }

        // 도로, 도시 생성
        List<Way> ways = new List<Way>();
        List<City> citys = new List<City>();

        for (int i = 0; i < way_length.Count; i++)
        {
            ways.Add(new Way() { index = i, length = way_length[i] });
        }

        for (int i = 0; i < city_price.Count; i++)
        {
            citys.Add(new City() { index = i, price = city_price[i] });
        }

        // 자동차 생성
        int index = 0;
        Car car = new Car() { currentCity = citys[index], nextWay = ways[index] };
        List<City> city_passed = new List<City>();

        while (true)
        {
            city_passed.Add(car.currentCity);

            if (car.currentCity.index == citys.Count - 1)
            {
                break;
            }

            int price_cheapest = int.MaxValue;

            foreach (var city in city_passed)
            {
                if (city.price < price_cheapest)
                {
                    price_cheapest = city.price;
                }
            }

            index++;
            car.buy(car.nextWay.length, price_cheapest);
            car.currentCity = citys[index];
            try { car.nextWay = ways[index]; } catch (Exception) { /* out of index 방지 */ }
        }

        Console.WriteLine(car.fee);
    }
}