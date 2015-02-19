using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trulon.Models.Maps
{
    using global::Trulon.Enums;
    using global::Trulon.Structs;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Level1 : Map
    {
        public Level1()
        {
            this.Obsticles = new Obsticle[]
                                       {
                                       //    new Obsticle(0, 346, 360, 20, Direction.Up),
                                       //    new Obsticle(310, 390, 20, 15, Direction.Left),
                                       //    new Obsticle(350, 311, 200, 20, Direction.Up),
                                           //HUD
                                           new Obsticle(0, 360, 130, 0, Direction.Down),
                                           new Obsticle(115, 375, 20, 90, Direction.Left),
                                           new Obsticle(115, 450, 1100, 0, Direction.Down), 
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
