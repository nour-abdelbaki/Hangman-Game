using System;

public class Player
{
    private int incorrectGuesses;

    public Player()
    {
        incorrectGuesses = 0;
    }

    public int getIncorrectGuesses()
    {
        return incorrectGuesses;
    }

    public void Count()
    {
        incorrectGuesses++;
    }

    public bool Lost(int maxIncorrectGuesses)
    {
        return incorrectGuesses >= maxIncorrectGuesses;
    }

    public void Submit(Word word, char letter)
    {
        word.Guess(letter);
        word.Solved();
    }
}