using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models
{
    public abstract class Item : GameObject
    {
        protected Item(string name, Texture2D image, Rectangle bounds, Vector2 position)
            : base(name, image, bounds, position)
        {

        }

    }
}
