//Guessing Game

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string MasterCode = "";

        Console.WriteLine("Please set the Master Code : ");
        MasterCode = Console.ReadLine();
        Console.WriteLine("3 Chances Left");

        string GuessWord = "";
        int Count = 0;
        int Chances = 3;
        bool LimitOver = false;
        while (GuessWord != MasterCode  && !LimitOver)
        {
            if (Count < Chances)
            {
                Console.WriteLine("Guess the word ");
                GuessWord = Console.ReadLine();
                Count++;

            }
            else
            {
                LimitOver = true;

            }
        }
        if (LimitOver)
        {
            Console.WriteLine("You Loose");
        }
        else
        {
            Console.WriteLine("You Won");

        }
       

    }
}
