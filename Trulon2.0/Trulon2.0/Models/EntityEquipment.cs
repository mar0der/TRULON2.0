namespace Trulon.Models
{
    using System.Collections.Generic;
    using global::Trulon.Enums;
    using global::Trulon.Models.Items;

    public class EntityEquipment
    {

        public EntityEquipment()
        {
            this.CurrentEquipment = new Dictionary<EquipmentSlots, Equipment>();
            //this.CurrentEquipment.Add(EquipmentSlots.Head, null);
            //this.CurrentEquipment.Add(EquipmentSlots.Body, null);
            //this.CurrentEquipment.Add(EquipmentSlots.LeftHand, null);
            //this.CurrentEquipment.Add(EquipmentSlots.RightHand, null);
            //this.CurrentEquipment.Add(EquipmentSlots.Feet, null);
        }

        public Dictionary<EquipmentSlots, Equipment> CurrentEquipment { get; set; }

    }
}
