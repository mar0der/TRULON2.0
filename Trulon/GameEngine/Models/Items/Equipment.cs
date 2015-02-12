using GameEngine.Enums;

namespace GameEngine.Models.Items
{
    public abstract class Equipment : Item
    {
        protected Equipment(string name, EquipmentSlots slot)
            : base(name)
        {
            this.Slot = slot;
        }

        public EquipmentSlots Slot { get; set; }
    }
}
