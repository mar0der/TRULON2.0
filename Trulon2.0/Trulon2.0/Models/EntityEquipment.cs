using System.Collections.Generic;
using GameEngine.Enums;

namespace Trulon.Models
{
    public class EntityEquipment
    {
        private Dictionary<EquipmentSlots, Item> currentEquipment = new Dictionary<EquipmentSlots, Item>();

        public EntityEquipment()
        {
            this.currentEquipment.Add(EquipmentSlots.Head, null);
            this.currentEquipment.Add(EquipmentSlots.Body, null);
            this.currentEquipment.Add(EquipmentSlots.Feet, null);
            this.currentEquipment.Add(EquipmentSlots.LeftHand, null);
            this.currentEquipment.Add(EquipmentSlots.RightHand, null);
        }

    }
}
