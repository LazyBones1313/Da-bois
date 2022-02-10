using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class SecretWord
    {
        private string _fileName;

        private List<string> _wordList = new List<string>();
        private List<string> _guessedLetters = new List<string>();
        private string _currentWord = "";
        public int _currentWord2 = 0;

        public SecretWord()
        {
            _fileName = "Game/words.txt";
            UploadListFromTxt(_fileName);
            Pick();
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
            // Print secret word
            //    or
            // Return secret word
        }

        public void IsFound()
        {

        }
        
        public void ContainsLetter()
        {
            
        }
    }
}

