using System;
using System.Formats.Asn1;
// using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string _book = "1 Nephi";
        int _chapter = 3;
        int _verse = 7;
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string scriptureText = "E aconteceu que eu, Néfi, disse a meu pai: Eu irei e cumprirei as ordens do Senhor, porque sei que o Senhor nunca dá ordens aos filhos dos homens sem antes preparar um caminho pelo qual suas ordens possam ser cumpridas.";
        Reference reference1 = new Reference(_book, _chapter, _verse, 8);
        // Word word1 = new Word(scriptureText);
        Scriptures scripture1 = new Scriptures(reference1,scriptureText);
        scripture1.GetDisplayText();
        string answer;
        //bool allHidden = false;

        do 
        {
            // allHidden = scripture1.IsCompletelyHidden();
            Console.WriteLine("Press enter to continue or quit to end: ");
            answer = Console.ReadLine();
            if (answer != "quit" )
            {
                scripture1.HideRandomWords();
                scripture1.GetDisplayText();
            }
        } while(answer != "quit" && !scripture1.IsCompletelyHidden());
      










    }
}