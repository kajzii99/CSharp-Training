using System;

class Program
{
    public static void Main()
    {

        zadanie1();
        foregroundColor();
        zadanie2();

    }
    static void foregroundColor()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    static void zadanie1()
    {
        Console.WriteLine("Wprowadz temp w st. Celsjusza");
        int degrees = Convert.ToInt32(Console.ReadLine());

        double fahrenheitDeg = (degrees * 1.8) + 32;

        Console.WriteLine($"Temperatura w stopnich Fahreheita to {fahrenheitDeg}");
    }

    static void zadanie2()
    {
        Console.WriteLine("WProwadz 3 liczby");
        long liczba1 = Convert.ToInt64(Console.ReadLine());
        long liczba2 = Convert.ToInt64(Console.ReadLine());
        long liczba3 = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine($"Najwieksza liczaba to: {(Math.Max(Math.Max(liczba1, liczba2), liczba3))}");
        Console.WriteLine($"Najmniejsza liczba to: {(Math.Min(Math.Min(liczba1, liczba2), liczba3))}");
    }
}