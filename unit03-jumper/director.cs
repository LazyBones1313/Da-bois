using System

public class Director
{   
    //Step 1: Get hangman variable

    //Step 2: Hangman will read hangman variable

    //Step 3: Hangman display stage

    //Step 3.5:If hangman variable = 7, director display "You Lose. Play again?"

    //Step 4: Word generates random number

    //Step 5: Word takes word that coresponds with number

    //Step 6: Word displays word in blank letters

    //Step 7: User input asks user input

    //Step 8: Word searches for instances of word

    //Step 9: If letter is found, word will unblank letter, else add one to hangman variable

    //Step 10: if all letters found, director display "You win. Play again?"

    //Start over
    string userChoice = "";

    public Director() 
    {
        
    }
    public void StartGame() 
    {
        while (isPlaying && score != 0)
        {
            GetInputs();
            CompareCards();
            DoOutputs();
        }
    }
    public void StartGame()
    {
        Console.WriteLine("This is a game");
    }
    Hangman hangman = new Hangman();
    Console.WriteLine("   -----");
    Console.WriteLine("   |    |");
    Console.WriteLine("   |     ");
    Console.WriteLine("   |     ");
    Console.WriteLine("   |     ");
    Console.WriteLine("_________     ");
}