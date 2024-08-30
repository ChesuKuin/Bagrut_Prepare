using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize a queue with some integer values
        Queue<int> q = new Queue<int>(new[] { 5, 11, 6, 9, 3, 6, 3 });

        // Asking the user about which number they want the information
        Console.WriteLine("Type in the index of the element you want to see (starting from 1).");
        Console.WriteLine("Numbers: 5, 11, 6, 9, 3, 6, 3.");

        int m;
        // Try to parse the user input to an integer
        bool isValidInput = int.TryParse(Console.ReadLine(), out m);

        // Check if the input is valid and within the range of the queue
        if (!isValidInput || m < 1 || m > q.Count)
        {
            Console.WriteLine("Invalid input or index out of range.");
        }
        else
        {
            // Convert the queue to an array and print the element at the given index (adjusted for 1-based indexing)
            Console.WriteLine($"You chose number: {q.ToArray()[m - 1]}");
            // Check if the chosen number is a 'magic element' and print the result
            Console.WriteLine($"Is the chosen number a 'magic element'? {IsMagic(q, m - 1)}");
        }

        Console.WriteLine("Type in the value of n to check 'magic elements' at positions that are multiples of n (starting from 1).");
        int n;
        isValidInput = int.TryParse(Console.ReadLine(), out n);

        if (!isValidInput || n <= 0 || n > q.Count)
        {
            Console.WriteLine("Invalid input or n is out of range.");
        }
        else
        {
            // Check if all elements at positions that are multiples of n are 'magic elements'
            Console.WriteLine($"Are all elements at positions multiple of {n} 'magic elements'? {NMagic(q, n)}");
        }
    }

    // Method to determine if the element at the specified index is a 'magic element'
    public static bool IsMagic(Queue<int> q, int m)
    {
        // 'Magic element' conditions: must not be the first or last element in the queue
        if (m <= 0 || m >= q.Count - 1)
            return false;

        // Convert the queue to an array for index access
        int[] elements = q.ToArray();

        // Check if the element is the sum of its immediate neighbors
        return elements[m] == elements[m - 1] + elements[m + 1];
    }

    public static bool NMagic(Queue<int> q, int n)
    {
        int count = q.Count;
        int index = n - 1;  // Adjust for 1-based index

        while (index < count)
        {
            if (!IsMagic(q, index))
                return false;

            index += n; 
        }

        return true;
    }
}
