using System;

public abstract class Word
{
    public string secretWord;
    private string guessedLetters;
    private bool solved;
    public string GetSecretWord()
    {
        return secretWord;
    }
    public Word()
    {
        secretWord = "";
        guessedLetters = "";
    }

    public Word(string word) : this()
    {
        choose(word);
    }

    protected void choose(string word)
    {
        secretWord = word.ToLower();
        solved = false;
    }

    public void Guess(char letter)
    {
        letter = char.ToLower(letter);

        if (!guessedLetters.Contains(letter))
        {
            guessedLetters += letter;
        }
    }

    public void Solved()
    {
        solved = true;

        for (int i = 0; i < secretWord.Length; i++)
        {
            char c = secretWord[i];
            if (c != ' ' && !guessedLetters.Contains(c))
            {
                solved = false;
                break;
            }
        }
    }

    public bool IsSolved()
    {
        return solved;
    }

    public string Display()
    {
        string result = "";

        for (int i = 0; i < secretWord.Length; i++)
        {
            char c = secretWord[i];

            if (c == ' ')
            {
                result += "  ";
            }
            else if (guessedLetters.Contains(c))
            {
                result += c + " ";
            }
            else
            {
                result += "_ ";
            }
        }
        return result;
    }
}