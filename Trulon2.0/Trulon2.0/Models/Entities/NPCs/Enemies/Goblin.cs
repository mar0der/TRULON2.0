namespace Trulon.Models.Entities.NPCs.Enemies
{
    using System;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Goblin : Enemy
    {
        private const string DefaultName = "Goblin";
        private const int DefaultAttackPoints = 15;
        private const int DefaultDefensePoints = 15;
        private const int DefaultSpeedPoints = 7;
        private const int DefaultHealthPoints = 90;
        private const int DefaultLevel = 3;
        private const int DefaultExperienceReward = 70;
        private const int DefaultCoinsReward = 50;
        private const int DefaultWidth = 64;

        private const int DefaultHeight = 64;

        public Goblin(int x, int y)
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
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + this.Width, y + this.Height, 0));
            this.IsAlive = true;
        }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            this.Image = texture;
            this.Position = position;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Image, this.Position, null, Color.White, 0F, Vector2.Zero, 1F, SpriteEffects.None, 0F);
        }

        protected override void Move()
        {
            //TODO: arteficial intelligence
        }
    }
}
