using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What's your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);  
        int y = 70;

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            //Console.WriteLine("You got an A+!");
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
            //Console.WriteLine("You got a B! ");
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
            //Console.WriteLine("You got a C! ");
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
            //Console.WriteLine("You got a D! ");
        }
        else
        {
            letter = "F";
            //Console.WriteLine("You got a F! :(");
        }
        //This if statement will determine whether or not user passed//
        if (grade >= y)
        {
            Console.WriteLine($"Congrats, you passed with grade {letter}! ");
        }
        else 
        {
            Console.WriteLine("I am sorry! Try harder next time.");
        }

    }
}