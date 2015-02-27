namespace Trulon.Models.Items.Equipments
{
    using global::Trulon.Enums;

    public class Boots : Equipment
    {
        private const Names DefaultName = Names.Boots;
        private const EquipmentSlots DefaultSlot = EquipmentSlots.Feet;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefensePointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 6;
        private const int DefaultPrice = 50;

        public Boots()
        {
            this.Name = DefaultName;
            this.Slot = DefaultSlot;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefensePointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.Price = DefaultPrice;
        }
    }
}
