using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities.NPCs.Allies
{
    using System.Collections.Generic;

    using global::GameEngine.Models.Items;
    using global::GameEngine.Models.Items.Equipments;
    using global::GameEngine.Models.Items.Potions;

    public class Vendor : Ally
    {
        public static List<Item> VendorInventory;

        public Vendor(string name = "Vendor",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            int attackPoints = 5,
            int defencePoints = 5,
            int speedPoints = 5,
            int healthPoints = 60,
            int level = 10,
            List<Item> inventory = null)
            : base(name, image, bounds, position, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {
            VendorInventory = new List<Item>()
            {
                new Helmet(),
                new Vest(),
                new Boots(),
                new DamagePotion(),
                new DefencePotion(),
                new HealthPotion(),
                new SpeedPotion()
            };
            this.Inventory = VendorInventory;
            this.Image = image;
        }

        protected override void Die()
        {
            //immortality
        }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            this.Image = texture;
            //Starting position of the vendor
            this.Position = position;

            //Set the vendor to be active

            //Set vendor health
        }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, null, Color.White, 0F, Vector2.Zero, 1F, SpriteEffects.None, 0F);
        }
    }
}
