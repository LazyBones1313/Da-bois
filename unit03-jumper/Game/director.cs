using System;

public class Director
{
    string userChoice = "";
    Hangman hangman = new Hangman();
    SecretWord word = new SecretWord();
    bool isPlaying = true;
    string keepPlaying = "";

    public void StartGame()
    {
        Console.WriteLine("This is a game");
    }
}