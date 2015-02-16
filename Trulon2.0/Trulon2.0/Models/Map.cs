namespace Trulon.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Map : GameObject
    {
        protected Map(int x, int y)
            : base(x, y)
        {

        }
    }
}
