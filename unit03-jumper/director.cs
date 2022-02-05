using System

public class Director
{
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