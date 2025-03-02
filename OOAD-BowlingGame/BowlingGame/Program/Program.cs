using OOAD_BowlingGame.BowlingGame.Services;

namespace OOAD_BowlingGame.BowlingGame.Program
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            GameManager game = new GameManager();
            game.StartGame();
        }
    }
}
