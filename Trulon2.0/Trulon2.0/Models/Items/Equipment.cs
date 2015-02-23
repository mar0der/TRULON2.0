namespace Trulon.Models.Items
{
    using global::Trulon.Enums;
    using global::Trulon.Interfaces;

    public abstract class Equipment : Item, IEquipable
    {
        public EquipmentSlots Slot { get; set; }
    }
}
