using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trulon.GUI.Menu
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Screen
    {
        public string Type;

        public virtual void LoadContent()
        {
            
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
