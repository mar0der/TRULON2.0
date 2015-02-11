namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Boss : Enemy
    {
        private const string Name = "Boss";
        private const int AttackPoints = 50;
        private const int DefencePoints = 50;
        private const int SpeedPoints = 5;
        private const int HealthPoints = 200;
        private const int Level = 5;
        private const int ExperienceReward = 100;
        private const int CoinsReward = 100;

        public Boss()
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
