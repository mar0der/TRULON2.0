using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Goblin : Enemy
    {
        public Goblin(
            string name = "Goblin",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            int attackPoints = 15,
            int defencePoints = 15,
            int speedPoints = 7,
            int healthPoints = 90,
            int level = 3,
            List<Item> inventory = null,
            bool isAlive = true,
            int experienceReward = 70,
            int coinsReward = 50)
            : base(
            name,
            image,
            bounds,
            position,
            attackPoints,
            defencePoints,
            speedPoints,
            healthPoints,
            level,
            inventory,
            isAlive,
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

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
