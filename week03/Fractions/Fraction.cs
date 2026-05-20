using System;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }
    public Fraction(int topValue)
    {
        top = topValue;
        bottom = 1;
    }
    public Fraction(int topValue, int bottomValue)
    {
        top = topValue;
        bottom = bottomValue;
    }
    public int GetTop()
    {
        return top;
    }
    public int GetBottom()
    {
        return bottom;
    }
    public void SetTop(int value)
    {
        top = value;
    }
    public void SetBottom(int value)
    {
        bottom = value;
    }
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}