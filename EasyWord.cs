using System;

public class easyWord : Word
{
    private static string[] words =
    {
        "polymorphism", "inheritance", "encapsulation", "abstraction", "interface"
    };

    public easyWord()
    {
        choose(randomWord());
    }

    private static string randomWord()
    {
        Random rand = new Random();
        return words[rand.Next(words.Length)];
    }
}