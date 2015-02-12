namespace GameEngine.Models.Entities.Players
{
    using System.Collections.Generic;

    public class Barbarian : Player
    {
        private const string Name = "Barbarian";
        private const int AttackPoints = 10;
        private const int DefencePoints = 5;
        private const int SpeedPoints = 3;
        private const int HealthPoints = 100;
        private const int Level = 1;
        private const int Experience = 0;
        private const int Coins = 10;
        private const int SkillPoints = 0;
        private const int AttackSkill = 0;
        private const int HealthSkill = 0;
        private const int DefenceSkill = 0;

        public Barbarian(string name)
            : base(
            Name,
            AttackPoints,
            DefencePoints,
            SpeedPoints,
            HealthPoints,
            Level,
            new List<Item>(),
            Experience,
            Coins,
            SkillPoints,
            AttackSkill,
            HealthSkill,
            DefenceSkill)
        {

        }
    }
}
