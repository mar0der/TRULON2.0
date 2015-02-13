using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities
{
    using System.Collections.Generic;

    public abstract class Player : Entity
    {
        protected Player(
            string name,
            Texture2D image,
            Rectangle bounds,
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
            : base(name, image, bounds, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
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


        protected abstract void AddExperience();

        protected abstract void AddCoins();

        protected abstract void Buy();

        protected abstract void AddSkillPoints();

        protected abstract void UseEquipment();

        protected abstract void DrinkPotion();

        protected abstract void Attack();

    }
}
