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
}