using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items.Potions
{
    public class SpeedPotion : Potion
    {
        private const string DefaultName = "SpeedPotion";
        private const int DefaultTimeout = 5;
        private const int DefaultCountdown = 5;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultSpeedPointsBuff = 10;
        public SpeedPotion()
        {
            this.Name = DefaultName;
            this.Timeout = DefaultTimeout;
            this.Countdown = DefaultCountdown;
            this.HasTimedOut = DefaultHasTimedOut;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }

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
