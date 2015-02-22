using Trulon.Models;
using Trulon.Models.Items;

namespace Trulon.GUI
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using CoreLogics;
    using Enums;
    using System.Linq;

    public class GameGUI : Game
    {
        private Engine engine;
        private readonly Vector2[] InventoryPositions = new Vector2[]
        {
         new Vector2(724, 630),
         new Vector2(807, 630),
         new Vector2(888, 630),
         new Vector2(964, 630),
         new Vector2(1037, 630)
        };

        private Dictionary<EquipmentSlots, Vector2> equipmentSotsPositions =
            new Dictionary<EquipmentSlots, Vector2>()
            {
                {EquipmentSlots.Head, new Vector2(5, 5)},
                {EquipmentSlots.LeftHand, new Vector2(74, 5)},
                {EquipmentSlots.RightHand, new Vector2(143, 5)},
                {EquipmentSlots.Body, new Vector2(212, 5)},
                {EquipmentSlots.Feet, new Vector2(281, 5)}
            };

        private Texture2D headImage;
        private Texture2D LeftImage;
        private Texture2D RightImage;
        private Texture2D BodyImage;
        private Texture2D FeetImage;

        

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
            //Display inventory
            for (int i = 0; i < this.engine.player.Inventory.Length; i++)
            {
                if (this.engine.player.Inventory[i] != null)
                {
                    spriteBatch.Draw(this.engine.player.Inventory[i].Image, this.InventoryPositions[i], Color.White);
                }
            }

            //Display current equipment
            var slots = (EquipmentSlots[])EquipmentSlots.GetValues(typeof(EquipmentSlots));
            foreach (var slot in slots)
            {
                DrawEquipmentSlot(spriteBatch, slot); 
            }

            //Labels
            spriteBatch.DrawString(this.engine.font, this.engine.player.Level.ToString(), new Vector2(520, 615), Color.SaddleBrown);
            spriteBatch.DrawString(this.engine.font, this.engine.player.AttackPoints.ToString(), new Vector2(520, 635), Color.SaddleBrown);
            spriteBatch.DrawString(this.engine.font, this.engine.player.DefensePoints.ToString(), new Vector2(520, 655), Color.SaddleBrown);
            spriteBatch.DrawString(this.engine.font, this.engine.player.SpeedPoints.ToString(), new Vector2(520, 675), Color.SaddleBrown);
            spriteBatch.DrawString(this.engine.font, this.engine.player.Experience.ToString(), new Vector2(520, 695), Color.SaddleBrown);
            
            //Inventory full message
            if (engine.player.inventoryIsFull)
            {
                spriteBatch.DrawString(this.engine.font, "The inventory is full. Use or drop something!", new Vector2(700, 566), Color.Red);
            }
        }

        private void DrawEquipmentSlot(SpriteBatch spriteBatch, EquipmentSlots slot)
        {
            var equipment = this.engine.player.PlayerEquipment.CurrentEquipment;
            var emptyImages = this.engine.AllEmptyEquipmentSlots;
            //Head
            if (equipment.ContainsKey(slot) && equipment[slot] != null)
            {
                this.headImage = equipment[slot].Image;
            }
            else
            {
                this.headImage = emptyImages[slot];
            }
            spriteBatch.Draw(this.headImage, this.equipmentSotsPositions[slot], Color.White);
        }
    }
}
