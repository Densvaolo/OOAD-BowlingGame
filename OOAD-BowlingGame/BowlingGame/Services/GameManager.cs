using OOAD_BowlingGame.BowlingGame.Factories;
using OOAD_BowlingGame.BowlingGame.Models;

namespace OOAD_BowlingGame.BowlingGame.Services
{
    public class GameManager
    {
        private Random random = new Random();
        public void StartGame()
        {
            Console.Write("Spelare 1, ange ditt namn: ");
            string name1 = Console.ReadLine();
            Player player1 = PlayerFactory.CreatePlayer(name1);

            Console.Write("Spelare 2, ange ditt namn: ");
            string name2 = Console.ReadLine();
            Player player2 = PlayerFactory.CreatePlayer(name2);

            Match match = new Match(player1, player2);

            // Slumpmässiga poäng för spelarna

            int score1 = random.Next(0, 301);
            int score2 = random.Next(0, 301);

            Console.WriteLine($"{player1.Name} fick {score1} poäng!");
            Console.WriteLine($"{player2.Name} fick {score2} poäng");

            match.RegisterScores(score1, score2);

            Player winner = match.GetWinner();
            if(winner!=null)
            {
                Console.WriteLine($"Vinnaren är {winner.Name} med {winner.Score} poäng");
            }
            else
            {
                Console.WriteLine("Matchen slutade oavgjort");
            }

            Console.WriteLine("Vill du spela igen? (ja/nej)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "ja")
            {
                StartGame();
            }
            else 
            {
                Console.WriteLine("Tack för att du spelade");
               
            }
            
        }
    }
}
