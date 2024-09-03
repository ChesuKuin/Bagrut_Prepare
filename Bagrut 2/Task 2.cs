using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1223, 134, 245, 300, 111, 777, 900, 195, 1234 };
        int password = 300;
        bool result = GetPass(arr, password);
        Console.WriteLine(result);

        password = 8888;
        result = GetPass(arr, password);
        Console.WriteLine(result);

        Console.WriteLine(string.Join(", ", arr));
    }

    static bool GetPass(int[] arr, int password)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == password)
                return false;
        }

        for (int i = arr.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[0] = password;
        return true;
    }
}
