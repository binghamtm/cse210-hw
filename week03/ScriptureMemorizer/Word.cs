public class Word
{
    private string _text;

    private bool _ishidden;

    public Word(string text)
    {
        _text = text;
        _ishidden = false;
    }

    public void Hide()
    {
        _text = new string('_', _text.Length);
        _ishidden = true;
    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        if (_ishidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}