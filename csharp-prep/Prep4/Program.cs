using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;
        Console.WriteLine("Enter in numbers. Press 0 to stop");
        while (num != 0){
            Console.Write("Enter in number.");
            num = int.Parse(Console.ReadLine());
            if (num != 0){
                numbers.Add(num);
            }
        }

        foreach (int number in numbers){
            Console.WriteLine(number);
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is {sum}.");
        double avg = numbers.Average();
        Console.WriteLine($"The average is {avg}.");
        int max = numbers.Max();
        Console.WriteLine($"The max is {max}.");
        numbers.Sort();
        int smallPositive = -1;

        foreach (int number in numbers){
            if (number >= 0){
                smallPositive = number;
                break;
            }
        }

        Console.WriteLine($"The smallest positive number is {smallPositive}.");

        Console.WriteLine("The sorted list:");

        foreach (int number in numbers){
            Console.WriteLine(number);
        }
        
    }
}