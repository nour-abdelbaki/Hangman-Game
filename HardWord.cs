using System;

public class hardWord : Word
{
    private static string[] sentences =
    {
        "tick tick tick that is the sound of your time running out",
        "the cat jumped onto the keyboard during the online meeting",
        "the arcade machine suddenly displayed my name on the screen"
    };

    public hardWord()
    {
        choose(randomSentence());
    }

    private static string randomSentence()
    {
        Random rand = new Random();
        return sentences[rand.Next(sentences.Length)];
    }
}