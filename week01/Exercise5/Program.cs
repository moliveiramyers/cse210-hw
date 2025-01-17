using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int square = SquareNumber(userNumber);

        DisplayResult(userName, square);







        void DisplayWelcome()
        {

            Console.WriteLine("Welcome to the program!");        

        }

        
        static string PromptUserName()
        {

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;

        }

        static int PromptUserNumber()
        {

            Console.Write("Please enter your favorite number: ");
            int UserNumber = int.Parse(Console.ReadLine());

            return UserNumber;

        } 
        static int SquareNumber(int userNumber)
        {

            int square = userNumber*userNumber;

            return square;

        }
      
       static void DisplayResult(string userName, int square)
       {

            Console.WriteLine($"{userName}, the square of your number is {square}");


       }
       
            
       
    }
}