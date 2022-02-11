using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class Hangman
    {
        //Variables
        private int _hangman = 0;

        //Constructor
        public Hangman()
        {

        }
        
        //Methods
        public void Display()
        {
            if (_hangman == 0)
            {
                Console.WriteLine("   _______");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |   ");
                Console.WriteLine("   |   ");
                Console.WriteLine("   |   ");
                Console.WriteLine("_______\n");
            }
            else if (_hangman == 1)
            {
                Console.WriteLine("   _______");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |     O");
                Console.WriteLine("   |   ");
                Console.WriteLine("   |   ");
                Console.WriteLine("_______\n");
            }
            if (_hangman == 2)
            {
                Console.WriteLine("   _______");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |     O");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |   ");
                Console.WriteLine("_______\n");
            }
            if (_hangman == 3)
            {
                Console.WriteLine("   _______");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |     O");
                Console.WriteLine(@"   |     |\");
                Console.WriteLine("   |   ");
                Console.WriteLine("_______\n");
            }
            if (_hangman == 4)
            {
                Console.WriteLine("   _______");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |     O");
                Console.WriteLine(@"   |    /|\");
                Console.WriteLine("   |   ");
                Console.WriteLine("_______\n");
            }
            if (_hangman == 5)
            {
                Console.WriteLine("   _______");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |     O");
                Console.WriteLine(@"   |    /|\");
                Console.WriteLine(@"   |    /");
                Console.WriteLine("_______\n");
            }
            if (_hangman == 6)
            {
                Console.WriteLine("   _______");
                Console.WriteLine("   |     |");
                Console.WriteLine("   |     O");
                Console.WriteLine(@"   |    /|\");
                Console.WriteLine(@"   |    / \");
                Console.WriteLine("_______\n");
                Console.WriteLine();
                Console.WriteLine("You lose!");
            }
        }

        public void AddLimb()
        {
            _hangman = _hangman + 1;
        }
        public bool IsDead()
        {
            if (_hangman == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}