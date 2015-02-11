namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Troll : Enemy
    {
        private const string Name = "Troll";
        private const int AttackPoints = 5;
        private const int DefencePoints = 5;
        private const int SpeedPoints = 5;
        private const int HealthPoints = 60;
        private const int Level = 1;
        private const int ExperienceReward = 50;
        private const int CoinsReward = 30;

        public Troll()
            : base(
            Name, 
            AttackPoints,
            DefencePoints, 
            SpeedPoints, 
            HealthPoints, 
            Level, 
            new List<Item>(), 
            ExperienceReward, 
            CoinsReward)
        {

        }
    }
}
