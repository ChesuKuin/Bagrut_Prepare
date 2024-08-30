using System;
using System.Collections.Generic;
using System.Linq;

public class BusStation
{
    private int num;
    private int[] arr = new int[10];
    private int amount;

    public BusStation(int num, int[] routes, int amount)
    {
        this.num = num;
        this.amount = amount;
        for (int i = 0; i < 10; i++)
        {
            if (i < routes.Length)
                arr[i] = routes[i];
            else
                arr[i] = 0;
        }
    }

    public int[] GetRoutes()
    {
        return arr.Take(amount).ToArray();
    }
}

public class Program
{
    public static int[] AllStations(BusStation[] arr)
    {
        if (arr.Length == 0) return new int[0];

        HashSet<int> commonRoutes = new HashSet<int>(arr[0].GetRoutes());

        foreach (var station in arr)
        {
            HashSet<int> currentRoutes = new HashSet<int>(station.GetRoutes());
            commonRoutes.IntersectWith(currentRoutes);

            if (commonRoutes.Count == 0)
                break;
        }

        return commonRoutes.ToArray();
    }

    public static void Main()
    {
        BusStation station1 = new BusStation(1, new int[] { 1, 2, 3, 4, 5 }, 5);
        BusStation station2 = new BusStation(2, new int[] { 3, 4, 5, 6 }, 4);
        BusStation station3 = new BusStation(3, new int[] { 1, 3, 5 }, 3);
        
        BusStation[] stations = { station1, station2, station3 };

        int[] result = AllStations(stations);

        Console.WriteLine("Routes stopping at all stations: " + string.Join(", ", result));
    }
}
