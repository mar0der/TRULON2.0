namespace Trulon.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using global::Trulon.Enums;

    public abstract class GameObject
    {
        public Names Name { get; set; }

        public Texture2D Image { get; set; }

        public virtual BoundingBox Bounds { get; set; }

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
        }
    }
}
