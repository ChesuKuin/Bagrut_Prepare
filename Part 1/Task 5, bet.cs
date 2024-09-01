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

    // Method to find the length of the longest subsequence where a number and its opposite are present
    public static int Longest(List<int> chain)
    {
        // Variable to keep track of the maximum length found
        int maxLength = -1;
        // HashSet to store unique numbers from the list
        HashSet<int> seenNumbers = new HashSet<int>(chain);

        // Iterate through each unique number in the HashSet
        foreach (int num in seenNumbers)
        {
            // Calculate the width of the subsequence for the current number
            int length = Width(chain, num);
            // Update maxLength if the current length is greater
            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        // Return the maximum length found
        return maxLength;
    }

    public static void Main()
    {
        // Example list of integers
        List<int> chain = new List<int> { -9, -1, 1, 22, 10, -2, 9, -10, 4 };
        // Calculate the length of the longest subsequence where a number and its opposite are present
        int result = Longest(chain);
        // Output the result
        Console.WriteLine(result);
    }
}
