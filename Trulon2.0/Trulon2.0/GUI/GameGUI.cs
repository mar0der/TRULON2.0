using System.Web.UI.WebControls;
using Trulon.Config;

namespace Trulon.GUI
{
    using System;
    using System.Collections.Generic;

    using global::Trulon.CoreLogics;
    using global::Trulon.Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GameGUI : Game
    {
        private Engine engine;
        private Vector2[] inventoryPositions = new Vector2[]
        {
         new Vector2(724, 630),
         new Vector2(807, 630),
         new Vector2(890, 630),
         new Vector2(970, 630),
         new Vector2(1040, 630)
        };

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
            //this.vendor = new Vendor(500, 500);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < this.engine.player.Inventory.Count; i++)
            {
                if (this.engine.player.Inventory[i].Image != null)
                {
                    spriteBatch.Draw(this.engine.player.Inventory[i].Image, this.inventoryPositions[i], Color.White);
                }
            }
        }
        
    }
}
