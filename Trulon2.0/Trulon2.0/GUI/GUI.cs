namespace Trulon.GUI
{
    using System;
    using System.Collections.Generic;
    using global::Trulon.Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GUI : IDrawable
    {
        public GUI()
        {
            Dictionary<EquipmentSlots, Rectangle> playersEquipment = new Dictionary<EquipmentSlots, Rectangle>();
                playersEquipment.Add(EquipmentSlots.Head, new Rectangle(5, 5, 30, 30));
                playersEquipment.Add(EquipmentSlots.LeftHand, new Rectangle(5, 40, 30, 30));
                playersEquipment.Add(EquipmentSlots.RightHand, new Rectangle(5, 75, 30, 30));
                playersEquipment.Add(EquipmentSlots.Body, new Rectangle(5, 110, 30, 30));
                playersEquipment.Add(EquipmentSlots.Feet, new Rectangle(5, 145, 30, 30));
        }

        public void Update()
        {

        }

        public Rectangle Bounds
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Texture2D Image
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Initialize(Texture2D texture, Vector2 position)
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }



        public int DrawOrder
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler<EventArgs> DrawOrderChanged;

        public bool Visible
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler<EventArgs> VisibleChanged;
    }
}
