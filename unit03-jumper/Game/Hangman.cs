public class Hangman
{
    private int _hangman = 0;
    public Hangman()
    {
        if (_hangman == 0)
        {
            Console.WriteLine("   _______");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |   ");
            Console.WriteLine("   |   ");
            Console.WriteLine("   |   ");
            Console.WriteLine("_______");
        }
        else if (_hangman == 1)
        {
            Console.WriteLine("   _______");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |     O");
            Console.WriteLine("   |   ");
            Console.WriteLine("   |   ");
            Console.WriteLine("_______");
        }
        if (_hangman == 2)
        {
            Console.WriteLine("   _______");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |     O");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |   ");
            Console.WriteLine("_______");
        }
        if (_hangman == 3)
        {
            Console.WriteLine("   _______");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |     O");
            Console.WriteLine(@"   |     |\");
            Console.WriteLine("   |   ");
            Console.WriteLine("_______");
        }
        if (_hangman == 4)
        {
            Console.WriteLine("   _______");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |     O");
            Console.WriteLine(@"   |    /|\");
            Console.WriteLine("   |   ");
            Console.WriteLine("_______");
        }
        if (_hangman == 3)
        {
            Console.WriteLine("   _______");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |     O");
            Console.WriteLine(@"   |    /|\");
            Console.WriteLine(@"   |    /");
            Console.WriteLine("_______");
        }
        if (_hangman == 3)
        {
            Console.WriteLine("   _______");
            Console.WriteLine("   |     |");
            Console.WriteLine("   |     O");
            Console.WriteLine(@"   |    /|\");
            Console.WriteLine(@"   |    / \");
            Console.WriteLine("_______");
        }
    }
    public void Meem()
    {
        if (_hangman == 0)
        {
            Console.WriteLine("Meem 2");
        }
    }
}