using OOAD_BowlingGame.BowlingGame.Models;

namespace OOAD_BowlingGame.BowlingGame.Factories
{
    public static class PlayerFactory //Använder Factory Pattern för att skapa Player-Objekt
    {
        public static Player CreatePlayer (string name)
        {
            return new Player(name);
        }

    }
}
