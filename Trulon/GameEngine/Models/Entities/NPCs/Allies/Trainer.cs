namespace GameEngine.Models.Entities.NPCs.Allies
{
    using System.Collections.Generic;

    public class Trainer : Ally
    {
        private const string Name = "Trainer";
        private const int AttackPoints = 5;
        private const int DefencePoints = 5;
        private const int SpeedPoints = 5;
        private const int HealthPoints = 60;
        private const int Level = 10;

        public Trainer()
            : base(
            Name, 
            AttackPoints,
            DefencePoints,
            SpeedPoints,
            HealthPoints,
            Level, 
            new List<Item>())
        {

        }
    }
}
