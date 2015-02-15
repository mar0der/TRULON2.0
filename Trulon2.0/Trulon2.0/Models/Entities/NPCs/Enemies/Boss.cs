using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Boss : Enemy
    {
        public Boss(
            string name = "Boss",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            int attackPoints = 50,
            int defencePoints = 50,
            int speedPoints = 5,
            int healthPoints = 200,
            int level = 5,
            List<Item> inventory = null,
            bool isAlive = true,
            int experienceReward = 100,
            int coinsReward = 100)
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
