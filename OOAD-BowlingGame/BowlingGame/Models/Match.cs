namespace OOAD_BowlingGame.BowlingGame.Models
{
    public class Match
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Match(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public void RegisterScores(int score1, int score2)
        {
            Player1.Score = score1;
            Player2.Score = score2;
        }

        public Player GetWinner() // Logik för vem som skall vinna
        {
            if (Player1.Score > Player2.Score)
                return Player1;
            else if (Player2.Score > Player1.Score)
                return Player2;
            else
                return null;

        }




    }
}

    
