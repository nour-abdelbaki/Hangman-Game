using kh = System.Console;
 
namespace hangmanOOP
{
    public class program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.startgame();
            kh.WriteLine("\n ame has ended thank you very much");
        }
    }
}