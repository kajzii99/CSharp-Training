using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadz swoją wage: ");
        double waga = ZwrocenieiLiczbyZKonsoli();

        Console.WriteLine("Wprowadz swoj wzrost: ");
        double wzrost = ZwrocenieiLiczbyZKonsoli();

        var bmiResult = LiczenieBmi(waga, wzrost);
        Console.WriteLine($"Waga: {waga} kg, wzrost: {wzrost} cm");
        Console.WriteLine($"Twoje BMI to {bmiResult}");
        BmiDefinition(bmiResult);
    }

    static double ZwrocenieiLiczbyZKonsoli()
    {
        double result;
        var walidacja = Console.ReadLine();
        try
        {
            result = Convert.ToDouble(walidacja);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wartosc musi byc liczba");
            result = ZwrocenieiLiczbyZKonsoli();
        }
        return result;
    }

    static double LiczenieBmi(double waga, double wzrost)
    {
        double bmi = (waga / (Math.Pow(wzrost, 2))) * 10000;
        double trueBmi = Math.Round(bmi, 1);
        return trueBmi;
    }

    static void BmiDefinition(double bmiResult)
    {
        if (bmiResult >= 18.5 && bmiResult <= 24.9)
        {
            Console.WriteLine("Waga prawidłowa!");
        }
        else if (bmiResult < 18.5) { Console.WriteLine("Niedowaga!"); }
        else { Console.WriteLine("Nadwaga!"); }
    }
}