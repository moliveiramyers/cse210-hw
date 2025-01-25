using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions fract1 = new Fractions();
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue());

        Fractions fract2 = new Fractions(5,1);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine


    }
}