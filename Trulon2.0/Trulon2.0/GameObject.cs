using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine
{
    public abstract class GameObject
    {
        protected GameObject(string name, Texture2D image, Rectangle bounds)
        {
            this.Name = name;
            this.Image = image;
            this.Bounds = bounds;
        }

        public string Name { get; set; }

        public Texture2D Image { get; set; }

        public Rectangle Bounds { get; set; }
    }
}
