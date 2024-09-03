using System;

public class TourPackage
{
    public int Id { get; private set; }
    public int Price { get; private set; }
    public int MaxTime { get; private set; }
    public int MaxData { get; private set; }
    public int Extra { get; private set; } = 0;

    public TourPackage(int id, int price, int maxTime, int maxData)
    {
        Id = id;
        Price = price;
        MaxTime = maxTime;
        MaxData = maxData;
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

    public static void Main()
    {

        TourPackage package = new TourPackage(1, 100, 200, 10);
        package.SetExtra(250, 12); 
        Console.WriteLine($"ID: {package.Id}, Extra: {package.Extra}");
    }
}
