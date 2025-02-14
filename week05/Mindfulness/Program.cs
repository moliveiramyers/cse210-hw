//Exceeding requirements: lines 18-27 from breathing activity- it increases the time each time it repeats the loop
// and lnes 52-59 of reflecting activity, it does not repeat same question.

using System;
using System.Diagnostics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        
        string answer = "";

        while (answer != "4")
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Refection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu");
            Console.WriteLine();
            answer = Console.ReadLine();

            if (answer == "1" )
            {
                BreathingActivinty activity1 = new BreathingActivinty();
                activity1.Run();

            }
            else if (answer ==  "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
            }
            else if (answer == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();

            }
            else if (answer == "4")
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("You have enterd an invalid option. Try again!");
            }        

        }
    }
    
}