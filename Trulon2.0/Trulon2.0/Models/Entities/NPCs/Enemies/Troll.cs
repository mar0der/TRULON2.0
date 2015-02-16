using Trulon.Models.Entities.Players;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Troll : Enemy
    {
        private const string name = "Troll";
        private const int attackPoints = 5;
        private const int defensePoints = 5;
        private const int speedPoints = 5;
        private const int healthPoints = 60;
        private const int level = 1;
        private const int experienceReward = 50;
        private const int coinsReward = 30;
        private const int width = 64;
        private const int height = 64;
        public Troll(int x, int y) : base(x, y)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.SpeedPoints = speedPoints;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.ExperienceReward = experienceReward;
            this.CoinsReward = coinsReward;
            this.Width = width;
            this.Height = height;
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
