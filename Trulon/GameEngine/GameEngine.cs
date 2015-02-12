namespace GameEngine
{
    using System;
    using global::GameEngine.Models.Entities;
    using global::GameEngine.Models.Entities.Players;

    public class GameEngine
    {
        public static Player CurrentPlayer { get; set; }

        public void Run()
        {
            
        }

        public static void CreateNewPlayer(string playerClass, string playerName)
        {
            switch (playerClass)
            {
                case "Barbarian":
                    CurrentPlayer = new Barbarian(playerName);
                    break;
                case "Paladin":
                    CurrentPlayer = new Paladin(playerName);
                    break;
                default:
                    throw new InvalidOperationException("Not chosen player type.");

            }
        }
        
    }
}
