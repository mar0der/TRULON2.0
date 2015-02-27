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
            this.ShopOrigin = new Vector2(this.engine.vendor.Position.X, this.engine.vendor.Position.Y - 138);

            // These are not magic number. The logic is each position has offset of 69px (64+5) from the rest
            this.vendorShopPositions = new Vector2[Config.TotalItemsCount]
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

        public Vector2 ShopOrigin { get; set; }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Display inventory
            for (int i = 0; i < this.engine.player.Inventory.Length; i++)
            {
                if (this.engine.player.Inventory[i] != null)
                {
                    spriteBatch.Draw(this.engine.player.Inventory[i].Image, this.inventoryPositions[i], Color.White);
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
                for (int i = 0; i < this.engine.vendor.Inventory.Length; i++)
                {
                    spriteBatch.Draw(this.engine.vendor.Inventory[i].Image, this.vendorShopPositions[i], Color.White);
                }
            }

            // Labels
            spriteBatch.DrawString(this.engine.font, this.engine.player.Level.ToString(), new Vector2(380, 617), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.AttackPoints.ToString(), new Vector2(380, 637), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.DefensePoints.ToString(), new Vector2(380, 657), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.SpeedPoints.ToString(), new Vector2(380, 677), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.Experience.ToString(), new Vector2(380, 697), Color.Black);
            spriteBatch.DrawString(this.engine.font, this.engine.player.Coins.ToString(), new Vector2(550, 697), Color.Black);

            spriteBatch.DrawString(this.engine.font, "Use: 1", new Vector2(730, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Use: 2", new Vector2(813, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Use: 3", new Vector2(894, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Use: 4", new Vector2(970, 613), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Use: 5", new Vector2(1042, 613), Color.LightBlue);

            spriteBatch.DrawString(this.engine.font, "Drop:Q", new Vector2(726, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Drop:W", new Vector2(809, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Drop:E", new Vector2(891, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Drop:R", new Vector2(967, 697), Color.LightBlue);
            spriteBatch.DrawString(this.engine.font, "Drop:T", new Vector2(1039, 697), Color.LightBlue);


            // Healthbar
            this.barCurrentWidth = (BarMaxWidth / this.engine.player.CurrentMaxHealth) * this.engine.player.HealthPoints;
            this.barColor = this.barCurrentWidth < HealthAlertLevel * this.engine.player.CurrentMaxHealth ? Color.Red : Color.White;

            spriteBatch.Draw(this.engine.healthBar, new Rectangle(10, 483, (int)this.barCurrentWidth, this.engine.healthBar.Height), this.barColor);

            spriteBatch.DrawString(this.engine.font, string.Format("{0}/{1}", this.engine.player.HealthPoints, this.engine.player.CurrentMaxHealth), new Vector2(65, 480), Color.White);

            // Inventory full message
            if (this.engine.player.InventoryIsFull)
            {
                spriteBatch.DrawString(this.engine.font, "The inventory is full. Use or drop something!", new Vector2(700, 566), Color.Red);
            }
        }

        protected override void Initialize()
        {
        }

        private void DrawEquipmentSlot(SpriteBatch spriteBatch, EquipmentSlots slot)
        {
            var equipment = this.engine.player.PlayerEquipment.CurrentEquipment;
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
