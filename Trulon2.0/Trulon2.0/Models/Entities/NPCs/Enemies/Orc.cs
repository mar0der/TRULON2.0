using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Orc : Enemy
    {
        public Orc(
            string name = "Orc",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            int attackPoints = 10,
            int defencePoints = 10,
            int speedPoints = 6,
            int healthPoints = 75,
            int level = 2,
            List<Item> inventory = null,
            bool isAlive = true,
            int experienceReward = 60,
            int coinsReward = 40)
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
