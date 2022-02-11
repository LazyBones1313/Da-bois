using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class SecretWord
    {  
        //Variables
        private const string FileName = "Game/words.txt";
        private List<string> _wordList = new List<string>();
        private List<string> _guessedLetters = new List<string>();
        private string _currentWord = "";

        //Constructor
        public SecretWord() => UploadListFromTxt(FileName);

        private void UploadListFromTxt(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                _wordList.Add(line);
            }
        }

        //Methods
        public void Pick()
        {
            Random random = new Random();
            int aWordIndex = random.Next(_wordList.Count);
            _currentWord = _wordList[aWordIndex];
        }

        public void Display()
        {
            foreach (char letter in _currentWord)
            {
                if (_guessedLetters.Contains(letter.ToString()))
                {
                    Console.Write($"{letter} ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }
        public void AddLetter(string letter)
        {
            _guessedLetters.Add(letter);
        }

        public bool IsFound()
        {
            foreach (char letter in _currentWord)
            {
                if (_guessedLetters.Contains(letter.ToString()))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool ContainsLetter(string letter)
        {
            if (_currentWord.Contains(letter))
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

