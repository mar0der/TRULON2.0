namespace Trulon.GUI
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using global::Trulon.Config;
    using global::Trulon.CoreLogics;
    using global::Trulon.Enums;

    public class GameGUI : Game
    {
        private const float BarMaxWidth = 175F;
        private const float HealthAlertLevel = 0.25F;
        
        private readonly Engine engine;
        private readonly Vector2[] inventoryPositions =
        {
            new Vector2(724, 630),
            new Vector2(807, 630),
            new Vector2(888, 630),
            new Vector2(964, 630),
            new Vector2(1037, 630)
        };

        private readonly Dictionary<EquipmentSlots, Vector2> equipmentSotsPositions = new Dictionary<EquipmentSlots, Vector2>()
        {
            { EquipmentSlots.Head, new Vector2(65, 523) },
            { EquipmentSlots.LeftHand, new Vector2(128, 587) },
            { EquipmentSlots.RightHand, new Vector2(3, 587) },
            { EquipmentSlots.Body, new Vector2(67, 587) },
            { EquipmentSlots.Feet, new Vector2(67, 651) }
        };

        private readonly Vector2[] vendorShopPositions;

        private Texture2D headImage;

        private float barCurrentWidth;
        private Color barColor = Color.White;

        public GameGUI(Engine engine)
        {
            this.engine = engine;

            // This 138 is not a magic number this is the height of 2 rows of items plus 2 spacings of 5 px. this will be changed to logic.
            this.ShopOrigin = new Vector2(this.engine.Vendor.Position.X, this.engine.Vendor.Position.Y - 138);

            // These are not magic number. The logic is each position has offset of 69px (64+5) from the rest
            this.vendorShopPositions = new Vector2[Config.TotalItemsCount]
            {
                new Vector2(this.ShopOrigin.X, this.ShopOrigin.Y),
                new Vector2(this.ShopOrigin.X + 69, this.ShopOrigin.Y),
                new Vector2(this.ShopOrigin.X + 138, this.ShopOrigin.Y),
                new Vector2(this.ShopOrigin.X + 207, this.ShopOrigin.Y),
                new Vector2(this.ShopOrigin.X + 276, this.ShopOrigin.Y),
                new Vector2(this.ShopOrigin.X, this.ShopOrigin.Y + 69),
                new Vector2(this.ShopOrigin.X + 69, this.ShopOrigin.Y + 69),
                new Vector2(this.ShopOrigin.X + 138, this.ShopOrigin.Y + 69),
                new Vector2(this.ShopOrigin.X + 207, this.ShopOrigin.Y + 69)
            };
        }

        public Vector2 ShopOrigin { get; set; }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Display inventory
            for (int i = 0; i < this.engine.Player.Inventory.Length; i++)
            {
                if (this.engine.Player.Inventory[i] != null)
                {
                    spriteBatch.Draw(this.engine.Player.Inventory[i].Image, this.inventoryPositions[i], Color.White);
                }
            }

            // Display current equipment
            var slots = (EquipmentSlots[])Enum.GetValues(typeof(EquipmentSlots));
            foreach (var slot in slots)
            {
                this.DrawEquipmentSlot(spriteBatch, slot);
            }

            // Display vendors shop
            if (this.engine.ShopOpened)
            {
                for (int i = 0; i < this.engine.Vendor.Inventory.Length; i++)
                {
                    spriteBatch.Draw(this.engine.Vendor.Inventory[i].Image, this.vendorShopPositions[i], Color.White);
                }
            }

            // Labels
            spriteBatch.DrawString(this.engine.Font, this.engine.Player.Level.ToString(), new Vector2(380, 617), Color.Black);
            spriteBatch.DrawString(this.engine.Font, this.engine.Player.AttackPoints.ToString(), new Vector2(380, 637), Color.Black);
            spriteBatch.DrawString(this.engine.Font, this.engine.Player.DefensePoints.ToString(), new Vector2(380, 657), Color.Black);
            spriteBatch.DrawString(this.engine.Font, this.engine.Player.SpeedPoints.ToString(), new Vector2(380, 677), Color.Black);
            spriteBatch.DrawString(this.engine.Font, this.engine.Player.Experience.ToString(), new Vector2(380, 697), Color.Black);
            spriteBatch.DrawString(this.engine.Font, this.engine.Player.Coins.ToString(), new Vector2(550, 697), Color.Black);

            spriteBatch.DrawString(this.engine.Font, "Use: 1", new Vector2(730, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Use: 2", new Vector2(813, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Use: 3", new Vector2(894, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Use: 4", new Vector2(970, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Use: 5", new Vector2(1042, 613), Color.LightBlue);

            spriteBatch.DrawString(this.engine.Font, "Drop:Q", new Vector2(726, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Drop:W", new Vector2(809, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Drop:E", new Vector2(891, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Drop:R", new Vector2(967, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.Font, "Drop:T", new Vector2(1039, 697), Color.LightBlue);

            // Healthbar
            this.barCurrentWidth = (BarMaxWidth / this.engine.Player.CurrentMaxHealth) * this.engine.Player.HealthPoints;
            this.barColor = this.barCurrentWidth < HealthAlertLevel * this.engine.Player.CurrentMaxHealth ? Color.Red : Color.White;

            spriteBatch.Draw(this.engine.HealthBar, new Rectangle(10, 483, (int)this.barCurrentWidth, this.engine.HealthBar.Height), this.barColor);

            spriteBatch.DrawString(this.engine.Font, string.Format("{0}/{1}", this.engine.Player.HealthPoints, this.engine.Player.CurrentMaxHealth), new Vector2(65, 480), Color.White);

            // Inventory full message
            if (this.engine.Player.InventoryIsFull)
            {
                spriteBatch.DrawString(this.engine.Font, "The inventory is full. Use or drop something!", new Vector2(700, 566), Color.Red);
            }
        }

        protected override void Initialize()
        {
        }

        private void DrawEquipmentSlot(SpriteBatch spriteBatch, EquipmentSlots slot)
        {
            var equipment = this.engine.Player.PlayerEquipment.CurrentEquipment;
            var emptyImages = this.engine.AllEmptyEquipmentSlots;

            // Head
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
