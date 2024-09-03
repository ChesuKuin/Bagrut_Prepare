using System;

public class TourPackage
{
    public int Id { get; private set; }
    public int Price { get; private set; }
    public int MaxTime { get; private set; }
    public int MaxData { get; private set; }
    public int Extra { get; private set; }

    public TourPackage(int id, int price, int maxTime, int maxData)
    {
        Id = id;
        Price = price;
        MaxTime = maxTime;
        MaxData = maxData;
        Extra = 0;
    }

    public void SetExtra(int minutes, int usage)
    {
        Extra = 0;
        if (minutes > MaxTime)
        {
            Extra += (minutes - MaxTime) * 1;
        }
        if (usage > MaxData)
        {
            Extra += (usage - MaxData) * 2;
        }
    }

    public static int Calculate(TourPackage[] packages)
    {
        int count = 0;
        foreach (var package in packages)
        {
            if (package.Extra > 0)
            {
                count++;
            }
        }
        return count;
    }

    public static int[] Customers(TourPackage[] packages)
    {
        int[] customerIds = new int[Calculate(packages)];
        int index = 0;
        foreach (var package in packages)
        {
            if (package.Extra > 0)
            {
                customerIds[index++] = package.Id;
            }
        }
        return customerIds;
    }

    public static void Main()
    {

        TourPackage[] packages = new TourPackage[]
        {
            new TourPackage(1, 100, 200, 10),
            new TourPackage(2, 150, 100, 5),
            new TourPackage(3, 200, 300, 20)
        };

        packages[0].SetExtra(250, 12); 
        packages[1].SetExtra(90, 4);  
        packages[2].SetExtra(350, 25);

        int[] customerIds = Customers(packages);
        Console.WriteLine("Идентификационные номера клиентов с дополнительными платежами:");
        foreach (var id in customerIds)
        {
            Console.WriteLine(id);
        }
    }
}
