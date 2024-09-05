using System;

public class Program
{
    public static int BiggestSum(int[] arr)
    {
        int maxSum = 0;
        int currentSum = 0;
        bool counting = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                if (counting)
                {
                    maxSum = Math.Max(maxSum, currentSum);
                    currentSum = 0; 
                }
                counting = true;
            }
            else if (counting)
            {
                currentSum += arr[i];
            }
        }

        return maxSum;
    }

    public static void Main()
    {
        int[] arr = {33, 0, 5, 4, 0, 17, 0, 4, 10, 0, 5, 14};
        Console.WriteLine(BiggestSum(arr)); 
    }
}
