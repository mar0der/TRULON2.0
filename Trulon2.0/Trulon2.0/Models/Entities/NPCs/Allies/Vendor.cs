using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trulon.Models.Items.Equipments;
using Trulon.Models.Items.Potions;

namespace Trulon.Models.Entities.NPCs.Allies
{
    public class Vendor : Ally
    {
        private const string DefaultName = "Vendor";
        private const int DefaultAttackPoints = 0;
        private const int DefaultDefensePoints = 0;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 60;
        private const int DefaultLevel = 10;
        private const int DefaultWidth = 64;
        private const int DefaultHeight = 64;

        public Vendor(int x, int y)
        {
            this.Name = DefaultName;
            this.BaseAttack = DefaultAttackPoints;
            this.BaseDefense = DefaultDefensePoints;
            this.BaseSpeed = DefaultSpeedPoints;
            this.BaseHealth = DefaultHealthPoints;
            this.Level = DefaultLevel;
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
            this.Position = new Vector2(x, y);
            this.Inventory = new List<Item>()
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
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, null, Color.White, 0F, Vector2.Zero, 1F, SpriteEffects.None, 0F);
        }

    }
}
