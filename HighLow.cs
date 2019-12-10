using System;
using System.Threading;
using System.Collections.Generic;

public class Guess 
{
    public int Min;
    public int Max;

    public Guess(int min, int max)
    {
        Min = min;
        Max = max;

    }
}  

class Program
{
    public static void Main()
    {
        Guess guess = new Guess(1, 100);
        Console.WriteLine("Think of a number between 1 - 100");
        Thread.Sleep(3000);
        nextGuess();
       
     void nextGuess()
    {
        Random rnd = new Random();
        int theGuess = rnd.Next(guess.Min, guess.Max);

        Console.WriteLine("Is your number " + theGuess + "? (response with 'higher', 'lower', or 'correct')");
        string answer = Console.ReadLine();

        if (answer == "higher")
        {
            guess.Min = theGuess;
            
            nextGuess();
        }
        else if (answer == "lower")
        {
            guess.Max = theGuess;
            nextGuess();
        }
    }    
    }
}
