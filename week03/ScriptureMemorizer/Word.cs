class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string value)
    {
        _text = value;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenVersion = "";

            for (int i = 0; i < _text.Length; i++)
            {
                hiddenVersion += "_";
            }

            return hiddenVersion;
        }

        return _text;
    }
}