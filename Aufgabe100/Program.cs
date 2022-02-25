namespace Aufgabe100;

public class Constants
{
    public const int MinNumber = 1;
    public const int MaxNumber = 100;
}

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        int guess = 0;
        int numberGuesses = 0;

        while (guess != number)
        {
            Console.Write($"Geben Sie eine Zahl zwischen {Constants.MinNumber} und {Constants.MaxNumber} ein: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess >= Constants.MinNumber && guess <= Constants.MaxNumber)
            {
                if (guess < number)
                {
                    Console.WriteLine("Falsch! Die Zahl ist größer! Versuchen Sie es nochmal!");
                    numberGuesses++;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Falsch! Die Zahl ist kleiner! Versuchen Sie es nochmal!");
                    numberGuesses++;
                }
                else
                {
                    Console.WriteLine("Glückwunsch! Sie haben die Zahl richtig geraten!");
                    numberGuesses++;
                    Console.WriteLine($"Du hast {numberGuesses} Rateversuche gebraucht!");
                }
            }
            else
            {
                Console.WriteLine($"Ungültige Eingabe! Bitte geben Sie eine Zahl zwischen {Constants.MinNumber} und {Constants.MaxNumber} ein!");
            }
        }

        Console.ReadKey();
    }
}
