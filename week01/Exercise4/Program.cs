using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int user_number = -1;
        while (user_number != 0)
        {
            Console.Write("please enter a number: ");
            string user_input = Console.ReadLine();
            user_number = int.Parse(user_input);
            if (user_number != 0)
            {
                numbers.Add(user_number);
            }
        }
        int sum_numbers = 0;
        foreach (int number in numbers)
        {
            sum_numbers = sum_numbers + number;
        }
        int count = numbers.Count;

        double average = (double)sum_numbers / count;

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"Sum: {sum_numbers}");
        Console.WriteLine($"count: {count}");
        Console.WriteLine($"average : {average}");
        Console.WriteLine($"largest number: {largest}");
    }
}