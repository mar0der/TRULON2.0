using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items.Potions
{
    public class DefencePotion : Potion
    {
        private const string DefaultName = "DefencePotion";
        private const int DefaultTimeout = 5;
        private const int DefaultCountdown = 5;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultDefensePointsBuff = 10;
        public DefencePotion()
        {
            this.Name = DefaultName;
            this.Timeout = DefaultTimeout;
            this.Countdown = DefaultCountdown;
            this.HasTimedOut = DefaultHasTimedOut;
            this.DefensePointsBuff = DefaultDefensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
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
