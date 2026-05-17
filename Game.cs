using System;
using kh = System.Console;

namespace hangmanOOP
{
    class Game
    {
        private Player Player; //word player
        private Word currentword;  //word class
        private int mistakes;
        private int maxmistakes = 6;

        public void startgame()
        {
            kh.WriteLine("---Hangman Game---");
            kh.WriteLine("Write your name :");
            string name = kh.ReadLine();
            Player = new Player(); 
            difficultyChoose();
            play();
            endthegame();

        }
        private void difficultyChoose()
        {
            kh.WriteLine("\n Choose the difficulty you want \n");
            kh.WriteLine("1) Easy \n");
            kh.WriteLine("2) Medium \n");
            kh.WriteLine("3) Hard \n");
            kh.WriteLine("\n write down the number of the difficulty you want \n");
            string choice = kh.ReadLine();

            switch (choice)
            {
                case "1":
                    currentword = new easyWord();  //here
                    break;

                 case "2":
                    currentword = new mediumWord();
                    break;
                case "3":
                    currentword = new hardWord();
                    break;
                default:
                    kh.WriteLine("invalid input, so easy level selected");
                    currentword = new easyWord();  //here
                    break;
            }


        }

        private void play()
        {
            while (mistakes < 6 && !currentword.IsSolved()) //iscomp
            {
                Console.Clear();
                drawhangman(mistakes);
                kh.WriteLine("\nthe remaining attempts are \t");
                kh.WriteLine(6-mistakes);
                kh.WriteLine(currentword.Display());
                char guess = char.Parse(kh.ReadLine()); 
                if (guess >= 'A' && guess <= 'Z')
                {

                }
                Player.Submit(currentword, guess);
                bool isCorrect = false;
                for (int i = 0; i < currentword.secretWord.Length; i++)
                {
                        if (currentword.secretWord[i] == guess)
                    {
                        isCorrect = true; 
                        break;
                    }
                }
                if (isCorrect == false)
                {
                    mistakes++;
                }

                

            }
        }


        private void endthegame()
        {
            kh.Clear();
            kh.WriteLine("\n-----Game Over!!!-------");
            drawhangman(mistakes);
            if (currentword.IsSolved()) //iscomp
            {
                kh.WriteLine("Congrats, u won!!!");
            }
            else
            {
                kh.WriteLine("Sorry, U lost :(");
                kh.WriteLine("\n the correct word was : \t");
                kh.WriteLine(currentword.secretWord); //getsecrte
            }
        }

        private void drawhangman(int mistakes)
        {
            switch (mistakes)
            {
                case 6:
                    kh.WriteLine("------\n      |\n      O\n     /|\\\n     / \\");
                    break;
                case 5:
                    kh.WriteLine("------\n      |\n      O\n     /|\\\n     / ");
                    break;                
                case 4:
                    kh.WriteLine("------\n      |\n      O\n     /|\\\n     ");
                    break;               
                case 3:
                    kh.WriteLine("------\n      |\n      O\n      |\\\n    ");
                    break;                
                case 2:
                    kh.WriteLine("------\n      |\n      O\n      |\n     ");
                    break;               
                case 1:
                    kh.WriteLine("------\n      |\n      O\n         \n     ");
                    break;               
                case 0:
                    kh.WriteLine("------\n      |\n       \n      \n     ");
                    break;
            }
        }

    }
}