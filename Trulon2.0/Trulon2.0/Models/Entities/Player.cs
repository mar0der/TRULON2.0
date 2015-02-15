using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trulon.Models.Items.Equipments;

namespace Trulon.Models.Entities
{
    public abstract class Player : Entity
    {
        protected Player(
            EntityEquipment playerEquipment,
            string name,
            Texture2D image,
            Rectangle bounds,
            Vector2 position,
            int attackPoints,
            int defencePoints,
            int speedPoints,
            int healthPoints,
            int level,
            List<Item> inventory,
            bool isAlive,
            int experience,
            int coins,
            int skillPoints,
            int attackSkill,
            int healthSkill,
            int defenceSkill)
            : base(name, image, bounds, position, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory, isAlive)
        {
            this.PlayerEquipment = playerEquipment;
            this.Experience = experience;
            this.Coins = coins;
            this.SkillPoints = skillPoints;
            this.AttackSkill = attackSkill;
            this.HealthSkill = healthSkill;
            this.DefenceSkill = defenceSkill;
        }

        public override int SpeedPoints
        {
            get
            {
                return base.SpeedPoints;
            }
        }

        private Dictionary<string, int> GetItemBonuses()
        {
            Dictionary<string, int> bonuses = new Dictionary<string, int>();
            //int attackBonus, defenceBonus, speedBonus, healthBonus;
            //foreach (var item in this.Inventory)
            //{
            //    //attackBonus += item is
            //}
            return bonuses;
        }

        public EntityEquipment PlayerEquipment { get; set; }
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
