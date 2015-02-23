namespace Trulon.Interfaces
{
    using global::Trulon.Enums;

    public interface IEquipable
    {
        EquipmentSlots Slot { get; set; }
    }
}
