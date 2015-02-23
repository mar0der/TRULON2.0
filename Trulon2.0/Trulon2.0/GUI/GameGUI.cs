using Trulon.Models;
namespace Trulon.GUI
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using CoreLogics;
    using Enums;
    using Config;

    public class GameGUI : Game
    {
        private readonly Engine engine;
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
                {EquipmentSlots.Head, new Vector2(65, 523)},
                {EquipmentSlots.LeftHand, new Vector2(128, 587)},
                {EquipmentSlots.RightHand, new Vector2(3, 587)},
                {EquipmentSlots.Body, new Vector2(67, 587)},
                {EquipmentSlots.Feet, new Vector2(67, 651)}
            };

        private Vector2[] vendorShopPositions;

        private Texture2D headImage;
        private Texture2D leftImage;
        private Texture2D rightImage;
        private Texture2D bodyImage;
        private Texture2D feetImage;

        public GameGUI(Engine engine)
        {
            this.engine = engine;
            //this 138 is not a magic number this is the height of 2 rows of items plus 2 spacings of 5 px. this will be changed to logic.
            this.ShopOrigin = new Vector2(this.engine.vendor.Position.X, this.engine.vendor.Position.Y - 138);
            //these are not magic number. The logic is each position has offset of 69px (64+5) from the rest
            vendorShopPositions = new Vector2[Config.TotalItemsCount]
            {
                new Vector2(this.ShopOrigin.X, this.ShopOrigin.Y),
                new Vector2(this.ShopOrigin.X+69, this.ShopOrigin.Y),
                new Vector2(ShopOrigin.X+138, ShopOrigin.Y),
                new Vector2(ShopOrigin.X+207, ShopOrigin.Y),
                new Vector2(ShopOrigin.X+276, ShopOrigin.Y),
                new Vector2(ShopOrigin.X, ShopOrigin.Y+69),
                new Vector2(ShopOrigin.X+69, ShopOrigin.Y+69),
                new Vector2(ShopOrigin.X+138, ShopOrigin.Y+69),
                new Vector2(ShopOrigin.X+207, ShopOrigin.Y+69)
            };
        }

        public Vector2 ShopOrigin{get; set;}

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

            //Display vendors shop

            if (this.engine.ShopOpened)
            {
                
                for (int i = 0; i < this.engine.vendor.Inventory.Length; i++)
                {
                    spriteBatch.Draw(this.engine.vendor.Inventory[i].Image, this.vendorShopPositions[i], Color.White);
                }
            }

            //Labels
            spriteBatch.DrawString(this.engine.font, this.engine.player.Level.ToString(), new Vector2(380, 617), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.AttackPoints.ToString(), new Vector2(380, 637), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.DefensePoints.ToString(), new Vector2(380, 657), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.SpeedPoints.ToString(), new Vector2(380, 677), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.Experience.ToString(), new Vector2(380, 697), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.Coins.ToString(), new Vector2(550, 697), Color.Black);
            
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
