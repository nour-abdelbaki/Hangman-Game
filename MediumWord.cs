using System;

public class mediumWord : Word
{
    private static string[] phrases =
    {
        "tonight is the night", "tell the truth", "practice makes perfect"
    };

    public mediumWord()
    {
        choose(randomPhrase());
    }

    private static string randomPhrase()
    {
        Random rand = new Random();
        return phrases[rand.Next(phrases.Length)];
    }
}