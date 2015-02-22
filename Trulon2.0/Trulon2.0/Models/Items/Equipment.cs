namespace Trulon.Models.Items
{
    using global::Trulon.Enums;
    using global::Trulon.Interfaces;

    public abstract class Equipment : Item, IEquipable
    {
        public EquipmentSlots Slot { get; set; }

        public int SpeedPointsBuff { get; set; }

        public int DefensePointsBuff { get; set; }

        public int AttackPointsBuff { get; set; }

        public int AttackRadiusBuff { get; set; }
    }
}
