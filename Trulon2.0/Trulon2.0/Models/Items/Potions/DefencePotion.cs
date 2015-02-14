using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items.Potions
{
    public class DefencePotion : Potion
    {
        public DefencePotion(
            string name = "Defense Potion",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            int timeout = 5,
            int countdown = 5,
            bool hasTimedOut = false,
            int defensePointsBuff = 10)
            : base(name, image, bounds, position, timeout, countdown, hasTimedOut)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
        public override void Initialize(Texture2D texture, Vector2 position)
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
