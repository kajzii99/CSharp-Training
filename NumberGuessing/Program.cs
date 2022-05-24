using System;

class Program
{
    static void Main(string[] args)
    {
        GetAppInfo();

        string userName = GetUserName();

        GreetUser(userName);

        Random random = new Random();
        int correctNumber = random.Next(1, 10);

        bool correctAnswer = false;

        Console.WriteLine("Zgadnij wylosowana liczbe od 1 do 10");

        while (correctAnswer == false)
        {
            string input = Console.ReadLine();
            int guess;

            bool isNumber = int.TryParse(input, out guess); // parse string to int

            if (!isNumber)  //jesli input nie jest liczba to petla
            {
                PrintColorMessage(ConsoleColor.Yellow, "Prosze wprowadzic liczbe: ");
                continue;
            }

            if(guess <1 || guess > 10)  //  || operator OR (albo)
            {
                PrintColorMessage(ConsoleColor.Yellow, "Prosze wprowadzic liczbe od 1 do 10 ");
                continue;
            }

            if(guess < correctNumber)
            {
                PrintColorMessage((ConsoleColor.Red), "Blędna odpowiedz, wylosowana liczba jest wieksza.");
            }
            else if(guess > correctNumber)
            {
                PrintColorMessage((ConsoleColor.Red), "Blędna odpowiedz, wylosowana liczba jest mniejsza.");
            }
            else
            {
                correctAnswer = true;
                PrintColorMessage(ConsoleColor.Green, "Brawo, wygrałeś!");
            }
            continue;
        }
    }

    static void GetAppInfo()
    {
        string appName = "Zgadywanie liczby";
        int appVersion = 1;
        string appAuthor = "Mateusz Kajzer";

        string info = $"Aplikacja to {appName} w wersji {appVersion} autorstwa {appAuthor}"; // interpolacja
        PrintColorMessage(ConsoleColor.Magenta, info);
    }

    static string GetUserName()
    {
        Console.WriteLine("Jak masz na imie?");
        string inputUserName = Console.ReadLine();
        return inputUserName;
    }

    static void GreetUser(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        string greet = $"Powodzenia {userName}, odganij liczbę...";
        Console.ResetColor();

        PrintColorMessage(ConsoleColor.Green, greet);
    }

    static void PrintColorMessage(ConsoleColor color, string message)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}


