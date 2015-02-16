using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trulon.Enums;

namespace Trulon.Models.Items
{
    public abstract class Equipment : Item
    {
        public EquipmentSlots Slot { get; set; }
    }
}
