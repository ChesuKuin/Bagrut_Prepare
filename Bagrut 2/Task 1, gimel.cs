using System;

class Program
{
    static void Main()
    {
        int[] arr = { 0, 11, 22, 33 };
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i] / 10;
            int digit = num % 10;
            if (digit == i)
                count++;
        }

        Console.WriteLine(count); 
    }
}
