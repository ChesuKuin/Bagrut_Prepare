using System;

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

    public bool IsStopping(int n)
    {
        for (int i = 0; i < amount; i++)
        {
            if (arr[i] == n)
                return true;
        }
        return false;
    }
}

public class Program
{
    public static void Main()
    {
        int[] routes = { 1, 2, 3, 4, 5 };
        BusStation station = new BusStation(1, routes, 5);

        Console.WriteLine(station.IsStopping(3)); // True
        Console.WriteLine(station.IsStopping(6)); // False
    }
}
