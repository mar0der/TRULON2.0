namespace Trulon.Models
{
    using System.Collections.Generic;
    using global::Trulon.Enums;
    using global::Trulon.Interfaces;

    public class EntityEquipment
    {

        public EntityEquipment()
        {
            this.CurrentEquipment = new Dictionary<EquipmentSlots, IEquipable>();
        }

        public Dictionary<EquipmentSlots, IEquipable> CurrentEquipment { get; set; }

    }
}
