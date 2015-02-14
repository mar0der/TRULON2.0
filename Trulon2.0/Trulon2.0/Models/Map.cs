using GameEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models
{
    public abstract class Map : GameObject
    {
        protected Map(string name, Texture2D image, Rectangle bounds, Vector2 position)
            : base(name, image, bounds, position)
        {

        }
    }
}
