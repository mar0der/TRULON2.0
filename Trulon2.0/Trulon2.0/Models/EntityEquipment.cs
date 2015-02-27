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
        }

        public Dictionary<EquipmentSlots, Equipment> CurrentEquipment { get; set; }
    }
}
