using System.Collections.Generic;
using Trulon.Enums;
using Trulon.Interfaces;

namespace Trulon.Models
{
    public class EntityEquipment
    {

        public EntityEquipment()
        {
            this.CurrentEquipment = new Dictionary<EquipmentSlots, IEquipable>();
        }

        public Dictionary<EquipmentSlots, IEquipable> CurrentEquipment { get; set; }

    }
}
