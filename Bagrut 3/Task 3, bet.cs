public static int MinTime(int[] arr, int amount)
{
    int left = 1, right = amount * arr[0];

    while (left < right)
    {
        int mid = (left + right) / 2;
        if (Total(arr, mid) >= amount)
            right = mid;
        else
            left = mid + 1;
    }

    return left;
}

public static int Total(int[] arr, int numSeconds)
{
    int totalBolts = 0;
    foreach (int machineTime in arr)
    {
        totalBolts += numSeconds / machineTime;
    }
    return totalBolts;
}
