using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Boss : Enemy
    {
        public Boss(
            string name = "Boss",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int attackPoints = 50,
            int defencePoints = 50,
            int speedPoints = 5,
            int healthPoints = 200,
            int level = 5,
            List<Item> inventory = null,
            int experienceReward = 100,
            int coinsReward = 100)
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
