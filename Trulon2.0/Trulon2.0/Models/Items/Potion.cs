using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items
{
    public abstract class Potion : Item
    {
        protected Potion(string name, Texture2D image, Rectangle bounds, Vector2 position, int timeout, int countdown, bool hasTimedOut)
            : base(name, image, bounds, position)
        {
            this.Timeout = timeout;
            this.Countdown = countdown;
            this.HasTimedOut = hasTimedOut;
        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
