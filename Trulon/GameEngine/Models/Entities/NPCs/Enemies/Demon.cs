namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Demon : Enemy
    {
        private const string Name = "Demon";
        private const int AttackPoints = 20;
        private const int DefencePoints = 20;
        private const int SpeedPoints = 8;
        private const int HealthPoints = 100;
        private const int Level = 4;
        private const int ExperienceReward = 80;
        private const int CoinsReward = 60;

        public Demon()
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
