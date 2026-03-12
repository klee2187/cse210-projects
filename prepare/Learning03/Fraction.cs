using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction (int wholeNum)
    {
        _topNum = wholeNum;
        _bottomNum = 1;
    }

    public Fraction(int topNum, int bottomNum)
    {
        _topNum = topNum;
        SetBottomNum(bottomNum);
    }

    public void SetBottomNum(int bottom)
    {   
        if (bottom != 0)
        {
            _bottomNum = bottom;
        }
        else
        {
            bottom = 1;
        }
    }
        
        public void SetTopNum(int top)
    {
        _topNum = top;

    }

    public int GetTop()
    {
        return _topNum;
    }

    public int GetBottom()
    {
        return _bottomNum;
    }

    public string GetFractionString()
    {
        string text = $"{_topNum}/{_bottomNum}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNum / (double)_bottomNum;
    }

}

