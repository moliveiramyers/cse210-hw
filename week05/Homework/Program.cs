using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("maria","fisica");
        //Console.Write(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Maria Joao", "Multiplication", "7.9", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writingAss1 = new WritingAssignment("Pedro Fontes", "European History", "The Causes of World War II");
        Console.WriteLine(writingAss1.GetSummary());
        Console.WriteLine(writingAss1.GetWritingInfo());
    }
}