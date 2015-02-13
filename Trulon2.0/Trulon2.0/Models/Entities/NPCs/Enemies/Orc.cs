using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Orc : Enemy
    {
        public Orc(
            string name = "Orc",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int attackPoints = 10,
            int defencePoints = 10,
            int speedPoints = 6,
            int healthPoints = 75,
            int level = 2,
            List<Item> inventory = null,
            int experienceReward = 60,
            int coinsReward = 40)
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
            experienceReward, 
            coinsReward)
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
