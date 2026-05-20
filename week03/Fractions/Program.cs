using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine("Fractions:");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());

        Console.WriteLine();

        f1.SetTop(3);
        f1.SetBottom(4);

        Console.WriteLine("Updated Fraction:");
        Console.WriteLine($"Top: {f1.GetTop()}");
        Console.WriteLine($"Bottom: {f1.GetBottom()}");
        Console.WriteLine($"Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");

        Console.WriteLine();

        Fraction f4 = new Fraction(1);
        Fraction f5 = new Fraction(5);
        Fraction f6 = new Fraction(3, 4);
        Fraction f7 = new Fraction(1, 3);

        Console.WriteLine("More Examples:");
        Console.WriteLine($"{f4.GetFractionString()} = {f4.GetDecimalValue()}");
        Console.WriteLine($"{f5.GetFractionString()} = {f5.GetDecimalValue()}");
        Console.WriteLine($"{f6.GetFractionString()} = {f6.GetDecimalValue()}");
        Console.WriteLine($"{f7.GetFractionString()} = {f7.GetDecimalValue()}");
    }
}