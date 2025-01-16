using System.Collections.Generic;
using System.Globalization;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
        int userNumber = 1; 
        int sum = 0;   
       // int greater = 0;   
        do
        {
            Console.Write("Enter a number! ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);
        foreach (int num in numbers)
        {
            sum += num; 
        }
        int largestNum = numbers.AsQueryable().Max();
        double averageNum = Queryable.Average(numbers.AsQueryable());

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {averageNum}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}