using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int input = -1;
        do
        {
            Console.Write("Enter a random number. When you are done entering the desired numbers, type 0. ");
            string valueFromUser = Console.ReadLine();

            input = int.Parse(valueFromUser);

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }

}