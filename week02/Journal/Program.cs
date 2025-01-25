
//Exceeding requirements: 
//Program: prepared the system to understand when the user enters
// something different from the options available and not 
// break the code but give the user the opportunity to try again (lines 64-63).

//Journal: on LoadFromFile, the method will get from user a file, if the file cannot
//be open or cannot be opened it will be displayed a error message explaining exactly
//the error (lines 57 and 77)



using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Journal choices = new Journal();

        do
       { 

        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Please, select one of the followig choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "1")
        {
            //1. Write"
            choices.AddEntry();
            
        }

        else if (choice == "2")
        {

            // 2. Display
            choices.DisplayAll();

        }
        else if (choice == "3")
        {
            // 3. Load
            Console.Write("What is the file name? ");
            string fileName = Console.ReadLine();
            choices.LoadFromFile(fileName);

        }

        else if (choice == "4")
        {
           
            //4. Save
            Console.WriteLine("Enter the file name: ");
            string fileName = Console.ReadLine();
            choices.SaveToFile(fileName);
            
        }

        else
        {
           Console.WriteLine("You've selected an invalid option.\nPlease, try again!\n ");
        }


        } while( choice != "5"); //5. Quit
        Console.WriteLine("You have successfully quit the program! ");


    }
}