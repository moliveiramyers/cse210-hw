using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal()
{
    public List<Entry>_entries = new List<Entry>();
    public PromptGenerator _prompt = new PromptGenerator();

    public void AddEntry()
    {
     // it will add from list to file   
     // all to same line
       string prompt = _prompt.GetRandomPrompt();
       Console.WriteLine($"Prompt: {prompt}");
        string resonse = Console.ReadLine(); 
        _entries.Add(new Entry(resonse, prompt));
        Console.WriteLine("Added!");
        
    }

    public void DisplayAll()
    {

        //it wll first retrieve from the list and slipt into pieces
        // so it will be more readable 
        foreach (Entry item in _entries)
        {
            string line = item.ToString();
            string[] parts = line.Split("$");
            foreach (var part in parts)
            {
                System.Console.WriteLine($"{part}");
            }
            
            Console.WriteLine();
        }
        Console.WriteLine();

    }

    public void SaveToFile(string file)
    {
       // it will retrieve each item from the list into 
       // a given file from user 
        using (StreamWriter outputFile = new StreamWriter(file))
        {       
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }        
        }
    }

    public void LoadFromFile(string file)
    {
        try // Using try to display a message in case it does not have anything in the list
        {
            _entries.Clear(); // clearing it first
                using (StreamReader reader = new StreamReader(file))
                { 
                
                    string line = reader.ReadLine(); // reading the file
                    while (line != null)
                    {
                       //Saparating the list data in the right way to the text file
                        string[] parts = line.Split("$");
                        string date = parts[0];
                        string question = parts[1];
                        string entry = parts[2];
                        _entries.Add(new Entry(entry, question) {_date = date});
                    }
                }
            Console.WriteLine("Your responses were loaded successfully!");
            Console.WriteLine();
        }   
        catch (Exception errorMessage)
        {
            Console.WriteLine($"Error loading to journal: {errorMessage.Message}");
        }
}
}