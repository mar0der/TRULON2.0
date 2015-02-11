using System.Collections.Generic;
namespace GameEngine.Models.Entities.Players
{
    using System.Collections.Generic;

    public class Paladin : Player
    {
        private const string Name = "Paladin";
        private const int AttackPoints = 7;
        private const int DefencePoints = 3;
        private const int SpeedPoints = 6;
        private const int HealthPoints = 90;
        private const int Level = 1;
        private const int Experience = 0;
        private const int Coins = 10;
        private const int SkillPoints = 0;
        private const int AttackSkill = 0;
        private const int HealthSkill = 0;
        private const int DefenceSkill = 0;
<<<<<<< HEAD

        protected Paladin()
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

=======

        protected Paladin()
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

>>>>>>> e38fed55bf23c1f3d88d539bb114967d3135231b
        }
    }
}
