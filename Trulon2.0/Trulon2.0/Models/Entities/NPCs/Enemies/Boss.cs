using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Boss : Enemy
    {
        private const string DefaultName = "Boss";
        private const int DefaultAttackPoints = 50;
        private const int DefaultDefensePoints = 50;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 200;
        private const int DefaultLevel = 5;
        private const int DefaultExperienceReward = 100;
        private const int DefaultCoinsReward = 100;
        private const int DefaultWidth = 128;

        private const int DefaultHeight = 128;

        public Boss(int x, int y)
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
