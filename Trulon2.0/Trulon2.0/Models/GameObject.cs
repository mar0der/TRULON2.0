namespace Trulon.Models
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class GameObject : IDrawable
    {
        protected GameObject(int x, int y)
        {
            this.Position = new Vector2(x, y);
        }

        public string Name { get; set; }

        public Texture2D Image { get; set; }

        public Rectangle Bounds { get; set; }

        public Vector2 Position { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

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
