using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            float average = (float)sum / numbers.Count;

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The max is: {max}");
        }
    }
}