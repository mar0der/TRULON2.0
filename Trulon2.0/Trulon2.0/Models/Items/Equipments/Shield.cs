using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trulon.Enums;
using Trulon.Interfaces;

namespace Trulon.Models.Items.Equipments
{
    public class Shield : Equipment
    {
        private const string DefaultName = "Shield";
        private const EquipmentSlots DefaultSlot = EquipmentSlots.LeftHand;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefensePointsBuff = 10;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultAttackRadiusBuff = 0;

        public Shield()
        {
            this.Name = DefaultName;
            this.Slot = DefaultSlot;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefensePointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.AttackRadiusBuff = DefaultAttackRadiusBuff;
        }
    }
}
