using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Items.Potions
{
    public class DamagePotion : Potion
    {
        public DamagePotion(
            string name = "Damage Potion",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            int timeout = 5, 
            int countdown = 5,
            bool hasTimedOut = false, 
            int attackPointsBuff = 10)
            : base(name, image, bounds, timeout, countdown, hasTimedOut)
        {
            this.AttackPointsBuff = attackPointsBuff;
        }

        public int AttackPointsBuff { get; set; }
    }
}
