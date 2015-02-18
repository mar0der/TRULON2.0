using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trulon.Enums;
using Trulon.Interfaces;

namespace Trulon.Models.Items.Equipments
{
    public class Boots : Equipment
    {
        private const string DefaultName = "Boots";
        private const EquipmentSlots DefaultSlot = EquipmentSlots.Feet;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefensePointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 5;
        private const int DefaultAttackRadiusBuff = 0;

        public Boots()
        {
            this.Name = DefaultName;
            this.Slot = DefaultSlot;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefensePointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.AttackRadiusBuff = DefaultAttackRadiusBuff;
        }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
