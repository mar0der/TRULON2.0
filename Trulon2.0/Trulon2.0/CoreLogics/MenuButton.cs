#region File Description
//-----------------------------------------------------------------------------
// MenuButton.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GuideUIWP7
{
    class MenuButton
    {
        private const float MAXSCALE = 1.5f;
        private const float SCALESPEED = 0.0066f;
        public Texture2D img;
        public Rectangle drawRect;
        public float scale;
        public bool isPressed;

        public MenuButton(Texture2D t)
        {
            this.img = t;
            this.drawRect = new Rectangle();
            this.drawRect.Width = img.Width;
            this.drawRect.Height = img.Height;
            this.scale = 1.0f;
        }

        public MenuButton(Texture2D t, Point p)
        {
            this.img = t;
            this.drawRect = new Rectangle();
            this.drawRect.Location = new Point(p.X, p.Y);
            this.drawRect.Width = img.Width;
            this.drawRect.Height = img.Height;
            this.scale = 1.0f;
        }

        public void SetLocation(Point p)
        {
            drawRect.Location = p;
        }

        public bool HasPoint(Point p)
        {
            return drawRect.Contains(p);
        }

        public bool HasPoint(int x, int y)
        {
            return drawRect.Contains(x, y);
        }

        public void Update(int etms)
        {
            if (isPressed && (scale < MAXSCALE))
            {
                scale += etms * SCALESPEED;
                if (scale > MAXSCALE)
                {
                    scale = MAXSCALE;
                }
            }
            else if (!isPressed && (scale > 1.0f))
            {
                scale -= etms * SCALESPEED;
                if (scale < 1.0f)
                {
                    scale = 1.0f;
                }
            }

            drawRect.Inflate(
                (int)((img.Width * scale - drawRect.Width) * 0.5f),
                (int)((img.Height * scale - drawRect.Height) * 0.5f));
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(img, drawRect, Color.White);
        }
    };
}
