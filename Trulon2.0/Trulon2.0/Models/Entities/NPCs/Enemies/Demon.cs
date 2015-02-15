using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Demon : Enemy
    {
        public Demon(
            string name = "Demon",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            int attackPoints = 20,
            int defencePoints = 20,
            int speedPoints = 8,
            int healthPoints = 100,
            int level = 4,
            List<Item> inventory = null,
            bool isAlive = true,
            int experienceReward = 80,
            int coinsReward = 60)
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

        protected override IList<Entity> GetEntitiesInRange(IList<Entity> entities)
        {
            throw new System.NotImplementedException();
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
