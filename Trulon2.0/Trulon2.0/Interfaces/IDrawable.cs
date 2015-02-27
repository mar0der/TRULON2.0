namespace Trulon.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IDrawable
    {
        Rectangle Bounds { get; set; }

        Texture2D Image { get; set; }

        Vector2 Position { get; set; }

        void Initialize(Texture2D texture, Vector2 position);

        void Update();

        void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
