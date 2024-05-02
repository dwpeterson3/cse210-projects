using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numbersInput;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        do
        {
            Console.Write("Enter a number: ");
            numbersInput = int.Parse(Console.ReadLine());

            if (numbersInput !=0)
            {
                numbers.Add(numbersInput);
            }

        } 
        while (numbersInput != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        int count = numbers.Count;
        int largestNumber = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/count} ");
        Console.WriteLine($"The largest number is: {largestNumber} ");
    }
}