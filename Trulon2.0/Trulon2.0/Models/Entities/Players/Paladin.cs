using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities.Players
{
    using System.Collections.Generic;

    public class Paladin : Player
    {
        public Paladin(
            string name = "Paladin",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int attackPoints = 7,
            int defencePoints = 3,
            int speedPoints = 6,
            int healthPoints = 90,
            int level = 1,
            List<Item> inventory = null,
            int experience = 0,
            int coins = 10,
            int skillPoints = 0,
            int attackSkill = 0,
            int healthSkill = 0,
            int defenceSkill = 0)
            : base(
            name, 
            image,
            bounds,
            attackPoints, 
            defencePoints, 
            speedPoints, 
            healthPoints, 
            level, 
            inventory, 
            experience, 
            coins, 
            skillPoints,
            attackSkill,
            healthSkill, 
            defenceSkill)
        {
        }

        protected override void Interact()
        {
            throw new System.NotImplementedException();
        }

        protected override void Move()
        {
            throw new System.NotImplementedException();
        }

        protected override void Die()
        {
            throw new System.NotImplementedException();
        }

        protected override void AddExperience()
        {
            throw new System.NotImplementedException();
        }

        protected override void AddCoins()
        {
            throw new System.NotImplementedException();
        }

        protected override void Buy()
        {
            throw new System.NotImplementedException();
        }

        protected override void AddSkillPoints()
        {
            throw new System.NotImplementedException();
        }

        protected override void UseEquipment()
        {
            throw new System.NotImplementedException();
        }

        protected override void DrinkPotion()
        {
            throw new System.NotImplementedException();
        }

        protected override void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}
