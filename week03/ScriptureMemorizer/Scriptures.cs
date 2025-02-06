using System;

public class Scriptures
{
    private Reference _reference;
    private List<Word>_word = new List<Word>();
    private Random _randomWords = new Random();

    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _reference.GetDisplay() ;
   
        string[] words = text.Split();
        foreach (string word in words)
        {
        
            _word.Add(new Word(word));
        }
        
    }

    public void HideRandomWords()
    {
        int quantityWords = _word.Count;
        int hiddenCount = 0;
        // this list to ensure that a word that was already replaced by underscore will not be repalced
        //again
        List<int>hiddenIndex = new List<int>();

        while (hiddenCount <1)
        {
            int randomIndex = _randomWords.Next(0, quantityWords);
            if (!_word[randomIndex].IsHidden() && !hiddenIndex.Contains(randomIndex))
            {
                _word[randomIndex].Hide(); 
                hiddenIndex.Add(randomIndex);
                hiddenCount++;  
            }
        }
    }
    public void GetDisplayText()
    {
        Console.WriteLine(_reference.GetDisplay());
        foreach(Word word in _word)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine("\n");
    
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;

    }

}