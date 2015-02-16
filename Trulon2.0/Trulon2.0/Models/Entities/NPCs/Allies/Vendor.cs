namespace Trulon.Models.Entities.NPCs.Allies
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using global::Trulon.Models.Items.Equipments;
    using global::Trulon.Models.Items.Potions;

    public class Vendor : Ally
    {
        public static List<Item> VendorInventory;

        private const string name = "Vendor";
        private const int attackPoints = 5;
        private const int defensePoints = 5;
        private const int speedPoints = 5;
        private const int healthPoints = 60;
        private const int level = 10;
        private const int width;
        private const int height;

        public Vendor(int x, int y) : base(x, y)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.SpeedPoints = speedPoints;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Width = width;
            this.Height = height;
            this.Inventory = VendorInventory;

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
