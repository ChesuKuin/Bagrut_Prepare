public static int Total(int[] arr, int numSeconds)
{
    int totalBolts = 0;
    foreach (int machineTime in arr)
    {
        totalBolts += numSeconds / machineTime;
    }
    return totalBolts;
}
