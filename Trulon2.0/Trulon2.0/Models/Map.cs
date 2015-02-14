using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models
{
    public abstract class Map : GameObject
    {
        protected Map(string name, Texture2D image, Rectangle bounds, Vector2 position)
            : base(name, image, bounds, position)
        {

        }
    }
}
