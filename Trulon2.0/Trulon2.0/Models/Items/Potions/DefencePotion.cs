using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Items.Potions
{
    public class DefencePotion : Potion
    {
        public DefencePotion(
            string name = "Defense Potion",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int timeout = 5,
            int countdown = 5,
            bool hasTimedOut = false,
            int defensePointsBuff = 10)
            : base(name, image, bounds, timeout, countdown, hasTimedOut)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
