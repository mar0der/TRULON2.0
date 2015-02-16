using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trulon.Enums;
using Trulon.Interfaces;

namespace Trulon.Models.Items
{
    public abstract class Equipment : Item, IEquipable
    {
        public EquipmentSlots Slot { get; set; }

        public int SpeedPointsBuff { get; set; }

        public int DefensePointsBuff { get; set; }

        public int AttackPointsBuff { get; set; }
    }
}
