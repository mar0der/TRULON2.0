using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Demon : Enemy
    {
        public Demon(
            string name = "Demon",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int attackPoints = 20,
            int defencePoints = 20,
            int speedPoints = 8,
            int healthPoints = 100,
            int level = 4,
            List<Item> inventory = null,
            int experienceReward = 80,
            int coinsReward = 60)
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
