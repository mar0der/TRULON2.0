namespace Trulon.Models.Maps
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using global::Trulon.Enums;
    using global::Trulon.Structs;

    public class Level1 : Map
    {
        public Level1()
        {
            this.Obsticles = new []
                                       {
                                       //    new Obsticle(0, 346, 360, 20, Direction.Up),
                                       //    new Obsticle(310, 390, 20, 15, Direction.Left),
                                       //    new Obsticle(350, 311, 200, 20, Direction.Up),
                                           //HUD
                                           new Obsticle(0, 450, 130, 100, Direction.Down),
                                           new Obsticle(115, 450, 30, 120, Direction.Left),
                                           new Obsticle(115, 560, 1100, 50, Direction.Down), 
                                       };
        }

        public override Obsticle[] Obsticles { get; set; }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
