using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models
{
    public abstract class Map : GameObject
    {
        public Map(string name, Texture2D image, Rectangle bounds)
            : base(name, image, bounds)
        {

        }
    }
}
