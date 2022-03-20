using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class Director
    {
        //Variables
        string userChoice = "";
        Hangman hangman = new Hangman();
        SecretWord word = new SecretWord();

        //Constructor
        public Director()
        {
            
        }

        //Game Logic
        public void StartGame()
        {   
            word.Pick();
            while (true)
            {    
                hangman.Display();
                word.Display();
                if (hangman.IsDead())
                {
                    break;
                }
                if (word.IsFound())
                {
                    Console.WriteLine("You Win! = )");
                    break;
                }
                Console.WriteLine("\n\nChoose a letter from the alphabet ");
                // userChoice = Console.ReadLine();
                if (word.ContainsLetter(userChoice))
                {
                    word.AddLetter(userChoice);
                    Console.WriteLine("\nCORRECT!");
                }
                else
                {
                    hangman.AddLimb();
                    Console.WriteLine("\nWrong :(");
                }
            }
        }
    }  
}

