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
            Console.WriteLine("This is a game");
        }
    }  
}

