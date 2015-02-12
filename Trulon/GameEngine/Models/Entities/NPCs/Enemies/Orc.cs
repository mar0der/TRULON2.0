namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Orc : Enemy
    {
       private const string Name = "Orc";
        private const int AttackPoints = 10;
        private const int DefencePoints = 10;
        private const int SpeedPoints = 6;
        private const int HealthPoints = 75;
        private const int Level = 2;
        private const int ExperienceReward = 60;
        private const int CoinsReward = 40;

        public Orc()
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

        protected override void Interact()
        {
            //Attack();
        }

        protected override void Move()
        {
            //arteficial intelligence
        }

        protected override void Die()
        {
            //die and drop item.
        }
    }
}
