using System;
using System.Linq;
public class Scripture
{
    private Reference _reference;

    private List<Word> _scripture = new List<Word>();
    private List<int> _randNumbers = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _scripture = text.Split(' ').Select(word => new Word(word)).ToList();
        _reference = reference;
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _scripture)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public void HideWord(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            _scripture[RandomNumber()].Hide();
        }
            
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = _scripture.All(n => n.IsHidden());
        return allHidden;
    }

    private int RandomNumber()
    {
        bool newNum = false;
        
        Random rand = new Random();
        int randomNumber = rand.Next(0, _scripture.Count);
        while (newNum == false)
        {
            if (!_randNumbers.Contains(randomNumber))
            {
                newNum = true;
                _randNumbers.Add(randomNumber);
            }
            else
            {
                randomNumber = rand.Next(0, _scripture.Count);
                
            }
        }
        
        return randomNumber;
        
    }
}