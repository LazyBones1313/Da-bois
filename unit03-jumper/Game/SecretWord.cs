using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class SecretWord
    {
        public int currentWord = 0;
        public int currentWord2 = 0;

        public SecretWord()
        {
            
        }

        public int Pick()
        {
            Random random = new Random();
            int aWord = random.Next(1,10);
            return aWord;
        }

        // public int convert()
        // {
        //     if (currentWord == 1)
        //     {
                
        //     }
        //     else
        //     {
        //         return "h";
        //     }
        // }

    }   
}

