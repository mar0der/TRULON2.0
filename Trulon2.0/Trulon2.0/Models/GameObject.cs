namespace Trulon.Models
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class GameObject : Microsoft.Xna.Framework.IDrawable
    {
        protected GameObject(string name, Texture2D image, Rectangle bounds, Vector2 position)
        {
            this.Name = name;
            this.Image = image;
            this.Bounds = bounds;
            this.Position = position;
        }

        public string Name { get; set; }

        public Texture2D Image { get; set; }

        public Rectangle Bounds { get; set; }

        public Vector2 Position { get; set; }

        public abstract void Initialize(Texture2D texture, Vector2 position);

        public abstract void Update();

        public abstract void Draw(SpriteBatch spriteBatch);

        public void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public int DrawOrder
        {
            get { throw new NotImplementedException(); }
        }

        public bool Visible
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler<EventArgs> DrawOrderChanged;

        public event EventHandler<EventArgs> VisibleChanged;
    }
}
