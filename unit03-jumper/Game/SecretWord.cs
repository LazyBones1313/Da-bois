using System;
using System.Collections.Generic;

namespace unit03_jumper.Game
{
    public class SecretWord
    {
<<<<<<< HEAD
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

=======
        Random random = new Random();
        int aWord = random.Next(1,10);
        return aWord;
    }
}
>>>>>>> 56f674ca786fe09b510d7bfb8e8ced1fc9a34e7d
