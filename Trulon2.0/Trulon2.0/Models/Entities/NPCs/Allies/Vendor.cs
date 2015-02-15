using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trulon.Models.Items.Equipments;
using Trulon.Models.Items.Potions;

namespace Trulon.Models.Entities.NPCs.Allies
{
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
            List<Item> inventory = null,
            bool isAlive = true)
            : base(name, image, bounds, position, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory, isAlive)
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

        protected override IList<Entity> GetEntitiesInRange(IList<Entity> entities)
        {
            throw new System.NotImplementedException();
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
