using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class SecretWord
    {
        private const string FileName = "Game/words.txt";
        private const string alphabet = "Game/alphabet.txt";

        private List<string> _wordList = new List<string>();
        private List<string> _guessedLetters = new List<string>();
        private List<string> letter = new List<string>();
        private string _currentWord = "";

        public SecretWord()
        {
            UploadListFromTxt(FileName);
        }

        private void UploadListFromTxt(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                _wordList.Add(line);
            }
        }
        public void Pick()
        {
            Random random = new Random();
            int aWordIndex = random.Next(_wordList.Count);
            _currentWord = _wordList[aWordIndex];
        }

        public void GetDisplay()
        {
            Console.WriteLine(_currentWord);
        }

        public void IsFound()
        {
            for (int i = 0; i < _currentWord.Length; i++)
            {
                char letter = _currentWord[i];
                Console.Write("_ ");
            }
        }
        
        public void AddLetter(string letter)
        {
            _guessedLetters.Add(letter);
        }
        public void ContainsLetter()
        {
            
        }
    }
}

