using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Troll : Enemy
    {
        private const string DefaultName = "Troll";
        private const int DefaultAttackPoints = 5;
        private const int DefaultDefensePoints = 5;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 60;
        private const int DefaultLevel = 1;
        private const int DefaultExperienceReward = 50;
        private const int DefaultCoinsReward = 30;
        private const int DefaultWidth = 64;
        private const int DefaultHeight = 64;

        public Troll(int x, int y)
        {
            this.Name = DefaultName;
            this.BaseAttack = DefaultAttackPoints;
            this.BaseDefense = DefaultDefensePoints;
            this.BaseSpeed = DefaultSpeedPoints;
            this.BaseHealth = DefaultHealthPoints;
            this.Level = DefaultLevel;
            this.ExperienceReward = DefaultExperienceReward;
            this.CoinsReward = DefaultCoinsReward;
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
            this.Position = new Vector2(x, y);
            this.IsAlive = true;
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + this.Width, y + this.Height, 0));
        }

        protected override void Move()
        {
            //arteficial intelligence
        }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
