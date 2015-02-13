using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Troll : Enemy
    {
        public Troll(
            string name = "Troll",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int attackPoints = 5,
            int defencePoints = 5,
            int speedPoints = 5,
            int healthPoints = 60,
            int level = 1,
            List<Item> inventory = null,
            int experienceReward = 50,
            int coinsReward = 30)
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
