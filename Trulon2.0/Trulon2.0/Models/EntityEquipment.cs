using System.Collections.Generic;
using GameEngine.Enums;

namespace Trulon.Models
{
    public class EntityEquipment
    {
        private Dictionary<EquipmentSlots, Item> currentEquipment = new Dictionary<EquipmentSlots, Item>();

        public EntityEquipment()
        {
            this.CurrentEquipment = currentEquipment;
        }

        public Dictionary<EquipmentSlots, Item> CurrentEquipment { get; set; }

    }
}
