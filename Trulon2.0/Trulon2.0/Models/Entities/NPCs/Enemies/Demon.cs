using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Demon : Enemy
    {
        private const string DefaultName = "Demon";
        private const int DefaultAttackPoints = 20;
        private const int DefaultDefensePoints = 20;
        private const int DefaultSpeedPoints = 8;
        private const int DefaultHealthPoints = 100;
        private const int DefaultLevel = 4;
        private const int DefaultExperienceReward = 80;
        private const int DefaultCoinsReward = 60;
        private const int DefaultWidth = 64;
        private const int DefaultHeight = 64;

        public Demon(int x, int y)
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
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + this.Width, y + this.Height, 0));
            this.Position = new Vector2(x, y);
            this.IsAlive = true;
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
