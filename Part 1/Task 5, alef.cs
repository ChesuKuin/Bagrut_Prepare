using System;
using System.Collections.Generic;

public class OppositeSubsequence
{
    // Method to calculate the width of the subsequence between a number and its opposite in a list
    public static int Width(List<int> chain, int num)
    {
        // The opposite number of the given number (negating the value)
        int oppositeNum = -num;
        // Variable to store the starting index of the given number in the list
        int startIndex = -1;

        // Loop to find the first occurrence of the given number in the list
        for (int i = 0; i < chain.Count; i++)
        {
            if (chain[i] == num)
            {
                startIndex = i; // Set startIndex to the index of the found number
                break; // Exit the loop as we found the first occurrence
            }
        }

        // If the number is not found in the list, return -1
        if (startIndex == -1) return -1;

        // Loop to find the first occurrence of the opposite number after the startIndex
        for (int i = startIndex + 1; i < chain.Count; i++)
        {
            if (chain[i] == oppositeNum)
            {
                // Return the width of the subsequence (i - startIndex + 1)
                return i - startIndex + 1;
            }
        }

        // If the opposite number is not found, return -1
        return -1;
    }

    public static void Main()
    {
        // Example list of integers
        List<int> chain = new List<int> { -9, -1, 1, 22, 10, -2, 9, -10, 4 };
        
        // Test case 1: Checking for the number -9
        int num1 = -9;
        int result1 = Width(chain, num1);
        Console.WriteLine(result1); // Output the result

        // Test case 2: Checking for the number -1
        int num2 = -1;
        int result2 = Width(chain, num2);
        Console.WriteLine(result2); // Output the result

        // Test case 3: Checking for the number 22
        int num3 = 22;
        int result3 = Width(chain, num3);
        Console.WriteLine(result3); // Output the result

        // Test case 4: Checking for the number 10
        int num4 = 10;
        int result4 = Width(chain, num4);
        Console.WriteLine(result4); // Output the result
    }
}
