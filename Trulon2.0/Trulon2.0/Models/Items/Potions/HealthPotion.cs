using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Items.Potions
{
    public class HealthPotion : Potion
    {
        public HealthPotion(
            string name = "Health Potion",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int timeout = 5,
            int countdown = 5,
            bool hasTimedOut = false,
            int healthPointsBuff = 10)
            : base(name, image, bounds, timeout, countdown, hasTimedOut)
        {
            this.HealthPointsBuff = healthPointsBuff;
        }

        public int HealthPointsBuff { get; set; }
    }
}
