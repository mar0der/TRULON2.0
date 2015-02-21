namespace Trulon.GUI
{
    using System;
    using System.Collections.Generic;

    using global::Trulon.CoreLogics;
    using global::Trulon.Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GameGUI
    {
        private Engine engine;

        public GameGUI(Engine engine)
        {
            Dictionary<EquipmentSlots, Rectangle> playersEquipment = new Dictionary<EquipmentSlots, Rectangle>();
                playersEquipment.Add(EquipmentSlots.Head, new Rectangle(5, 5, 30, 30));
                playersEquipment.Add(EquipmentSlots.LeftHand, new Rectangle(5, 40, 30, 30));
                playersEquipment.Add(EquipmentSlots.RightHand, new Rectangle(5, 75, 30, 30));
                playersEquipment.Add(EquipmentSlots.Body, new Rectangle(5, 110, 30, 30));
                playersEquipment.Add(EquipmentSlots.Feet, new Rectangle(5, 145, 30, 30));

            this.engine = engine;
        }

        public void Initialize()
        {
            //throw new NotImplementedException();
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(Image, Position, Color.White);
        }
        
    }
}
