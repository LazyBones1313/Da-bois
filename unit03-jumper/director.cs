using System

public class Director
{
    string userChoice = "";

    public Director() 
    {
        
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