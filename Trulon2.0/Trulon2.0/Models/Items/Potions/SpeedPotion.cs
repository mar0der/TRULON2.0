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
            Vector2 position = new Vector2(),
            int timeout = 5,
            int countdown = 5,
            bool hasTimedOut = false,
            int speedPointsBuff = 10
            )
            : base(name, image, bounds, position, timeout, countdown, hasTimedOut)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }

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
