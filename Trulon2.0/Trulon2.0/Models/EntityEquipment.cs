using Trulon.Interfaces;

namespace Trulon.Models
{
    using System.Collections.Generic;
    using GameEngine.Enums;
    public class EntityEquipment
    {

        public EntityEquipment()
        {
            this.CurrentEquipment = new Dictionary<EquipmentSlots, IEquipable>();
        }

        public Dictionary<EquipmentSlots, IEquipable> CurrentEquipment { get; set; }

    }
}
