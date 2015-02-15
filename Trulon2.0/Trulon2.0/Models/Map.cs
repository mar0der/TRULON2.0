namespace Trulon.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Map : GameObject
    {
        protected Map(string name, Texture2D image, Rectangle bounds, Vector2 position)
            : base(name, image, bounds, position)
        {

        }
    }
}
