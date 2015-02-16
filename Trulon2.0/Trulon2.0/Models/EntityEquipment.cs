using System.Collections.Generic;
using Trulon.Enums;
using Trulon.Interfaces;
using Trulon.Models.Items;

namespace Trulon.Models
{
    public class EntityEquipment
    {

        public EntityEquipment()
        {
            this.CurrentEquipment = new Dictionary<EquipmentSlots, Equipment>();
        }

        public Dictionary<EquipmentSlots, Equipment> CurrentEquipment { get; set; }

    }
}
