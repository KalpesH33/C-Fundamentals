// Online C# Editor for free
//Guessing Game

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     string MasterCode = "";
     
     Console.WriteLine("Please set the Master Code : ");
     MasterCode = Console.ReadLine();
    
     string GuessWord = "";
     int ChanceCount = 0;
     int Chances = 3;
     while (GuessWord != MasterCode )
     {
         if (ChanceCount < Chances )
         {  
             Console.WriteLine("Guess the word ");
             GuessWord = Console.ReadLine();
             ChanceCount++;
             
         }
         else 
         {
             Console.WriteLine("You lost");
             
         }
     }
 
     Console.WriteLine("You Won");
 
    }
}
