namespace Trulon.Models
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class GameObject : IDrawable
    {
        public string Name { get; set; }
        public Texture2D Image { get; set; }
        public BoundingBox Bounds { get; set; }
        public Vector2 Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual void Initialize(Texture2D texture, Vector2 position)
        {
            this.Image = texture;
            this.Position = position;
        }

        public virtual void Update()
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
        }

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
