using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs.Enemies
{
    public class Orc : Enemy
    {
        private const string DefaultName = "Orc";
        private const int DefaultAttackPoints = 10;
        private const int DefaultDefensePoints = 10;
        private const int DefaultSpeedPoints = 10;
        private const int DefaultHealthPoints = 75;
        private const int DefaultLevel = 2;
        private const int DefaultExperienceReward = 60;
        private const int DefaultCoinsReward = 40;
        private const int DefaultWidth = 64;
        private const int DefaultHeight = 64;
        public Orc(int x, int y)
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
        }

        protected override void Move()
        {
            //arteficial intelligence
        }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
