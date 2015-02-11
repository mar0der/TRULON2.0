namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Goblin : Enemy
    {
        private const string Name = "Goblin";
        private const int AttackPoints = 15;
        private const int DefencePoints = 15;
        private const int SpeedPoints = 7;
        private const int HealthPoints = 90;
        private const int Level = 3;
        private const int ExperienceReward = 70;
        private const int CoinsReward = 50;

        public Goblin()
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
