namespace Trulon.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Item : GameObject
    {
        protected Item(int x, int y)
            : base(x, y)
        {

        }

    }
}
