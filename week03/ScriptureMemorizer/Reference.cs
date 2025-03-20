public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        book = "1 Nephi";
        chapter = 1;
        verse = 1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        book = "1 Nephi";
        chapter = 1;
        startVerse = 1;
        endVerse = 2;
    }

    public string getDisplayText()
    {
        return "";
    }

    public void setReference()
    {

    }
}