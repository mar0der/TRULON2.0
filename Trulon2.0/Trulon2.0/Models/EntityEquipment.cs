namespace GameEngine.Models
{
    using System.Collections.Generic;
    using global::GameEngine.Enums;

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
