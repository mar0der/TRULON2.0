namespace GameEngine.Models.Entities
{
    using System.Collections.Generic;

    public abstract class Player : Entity
    {
        public Player(
            string name,
            int attackPoints,
            int defencePoints,
            int speedPoints,
            int healthPoints,
            int level,
            List<Item> inventory,
            int experience,
            int coins,
            int skillPoints,
            int attackSkill,
            int healthSkill,
            int defenceSkill)
            : base(name, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {
            this.Experience = experience;
            this.Coins = coins;
            this.SkillPoints = skillPoints;
            this.AttackSkill = attackSkill;
            this.HealthSkill = healthSkill;
            this.DefenceSkill = defenceSkill;
        }

        public int Experience { get; set; }
        public int Coins { get; set; }
        public int SkillPoints { get; set; }
        public int AttackSkill { get; set; }
        public int HealthSkill { get; set; }
        public int DefenceSkill { get; set; }


        public abstract void AddExperience();

        public abstract void AddCoins();

        public abstract void Buy();

        public abstract void AddSkillPoints();

        public abstract void UseEquipment();

        public abstract void DrinkPotion();

        public abstract void Attack();

    }
}
