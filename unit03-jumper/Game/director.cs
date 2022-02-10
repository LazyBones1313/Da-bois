using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class Director
    {
        string userChoice = "";
        Hangman hangman = new Hangman();
        SecretWord word = new SecretWord();
        bool isPlaying = true;
        string keepPlaying = "";
        public Director()
        {
            
        }

        public void StartGame()
        {
            while (isPlaying == true)
            {
                if (hangman.IsDead())
                {
                    isPlaying = false;
                }
                hangman.Display();
                word.Pick();
                word.IsFound();
                Console.WriteLine("\n\nChoose a letter from the alphabet ");
                userChoice = Console.ReadLine();
                
            }
        }
    }  
}

