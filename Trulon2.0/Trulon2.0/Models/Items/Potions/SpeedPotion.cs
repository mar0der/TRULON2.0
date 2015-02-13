using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Items.Potions
{
    public class SpeedPotion : Potion
    {
        public SpeedPotion
            (
            string name = "Speed Potion",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int timeout = 5, 
            int countdown = 5, 
            bool hasTimedOut = false, 
            int speedPointsBuff = 10
            ) : base(name, image, bounds, timeout, countdown, hasTimedOut)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
