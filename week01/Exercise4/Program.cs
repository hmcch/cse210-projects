using System;
using System.Collections.Generic;
// All Core Requirements Accomplished
// All stretch challenges accomplished #1 "Find the smallest positive number" lines of code 65-73 and #2 "Sort the list from lowest to highest number" lines of code 78-80.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        // Once you have a list, do the following:

        // Core Requirement #1
        // Compute the sum or total of the numbers in the list.


        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Core Requirement #2
        // Compute the average of the numbers in the list.


        int count = numbers.Count;
        // Using double to keep the decimals
        double average = (double)sum / count;

        Console.WriteLine($"The average is: {average}");

        // Core Requirement #3
        // Find the maximum or largest number in the list


        int maximum = numbers[0];

        foreach (int element in numbers)
        {
            if (element > maximum)
            {
                maximum = element;
            }
        }
        Console.WriteLine($"The largest number is: {maximum}");

        // Stretch Challenge #1
        // Find the smallest positive number

        int smallest = 999999;

        foreach (int element in numbers)
            if (element > 0 && element < smallest)
            {
                smallest = element;
            }

        Console.WriteLine($"The smallest positive number is: {smallest}");

        // Stretch Challenge #2
        // Sort the list from lowest to highest number

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        numbers.ForEach(Console.WriteLine);

    }
}