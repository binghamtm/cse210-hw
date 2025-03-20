public class Scripture
{
    Reference _reference;

    List<Word> _scripture = new List<Word>();

    public Scripture(Reference reference, string text)
    {

    }

    public string DisplayScripture(List<Word> scripture)
    {
        return "";
    }

    public void HideWord(int numberToHide)
    {

    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

    private int RandomNumber()
    {
        return 1;
    }
}