
using System;

class NumberGuessingGame
{
    static int GenerateGuess(int low, int high)
    {
        Random r = new Random();
        return r.Next(low, high + 1);
    }

    static void Main()
    {
        int low = 1, high = 100;
        string feedback = "";

        Console.WriteLine("Think of a number between 1 and 100");

        while (feedback != "correct")
        {
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Is it " + guess + "? (high/low/correct)");
            feedback = Console.ReadLine();

            if (feedback == "high") high = guess - 1;
            else if (feedback == "low") low = guess + 1;
        }

        Console.WriteLine("Guessed correctly!");
    }
}
