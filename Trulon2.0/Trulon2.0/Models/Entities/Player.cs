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
            int defenceSkill,
            int speedSkill,
            int healthSkill
            )
            : base(name, image, bounds, position, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory, isAlive)
        {
            this.PlayerEquipment = playerEquipment;
            this.Experience = experience;
            this.Coins = coins;
            this.SkillPoints = skillPoints;
            this.AttackSkill = attackSkill;
            this.DefenseSkill = defenceSkill;
            this.SpeedSkill = defenceSkill;
            this.HealthSkill = healthSkill;
            
        }
        public EntityEquipment PlayerEquipment { get; set; }
        public int Experience { get; set; }
        public int Coins { get; set; }
        public int SkillPoints { get; set; }
        public int AttackSkill { get; set; }
        public int DefenseSkill { get; set; }
        public int SpeedSkill { get; set; }
        public int HealthSkill { get; set; }

        public override int AttackPoints
        {
            get
            {
                return base.AttackPoints + this.EquipmentBuffs["attack"] + this.AttackSkill;
            }
        }

        public override int DefensePoints
        {
            get
            {
                return base.DefensePoints + this.EquipmentBuffs["defense"] + this.DefenseSkill;
            }
        }

        public override int SpeedPoints
        {
            get
            {
                return base.SpeedPoints+this.EquipmentBuffs["speed"]+this.SpeedSkill;
            }
        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints + this.HealthSkill;
            }
        }
        
        private Dictionary<string, int> EquipmentBuffs
        {
            get
            {
                Dictionary<string, int> buffs = new Dictionary<string, int>();
                int attackBuff = 0, defenseBuff = 0, speedBuff = 0;
                foreach (var item in this.PlayerEquipment.CurrentEquipment)
                {
                    attackBuff += item.Value.AttackPointsBuff;
                    defenseBuff += item.Value.DefensePointsBuff;
                    speedBuff += item.Value.SpeedPointsBuff;
                }
                buffs.Add("attack", attackBuff);
                buffs.Add("defense", defenseBuff);
                buffs.Add("speed", speedBuff);
                return buffs;
            }
        }

        protected abstract void AddExperience();

        protected abstract void AddCoins();

        protected abstract void Buy();

        protected abstract void AddSkillPoints();

        protected abstract void UseEquipment();

        protected abstract void DrinkPotion();

        protected abstract void Attack();




        
    }
}
