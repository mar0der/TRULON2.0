namespace Trulon.Models.Items.Equipments
{
    using global::Trulon.Enums;

    public class Boots : Equipment
    {
        private const string DefaultName = "Boots";
        private const EquipmentSlots DefaultSlot = EquipmentSlots.Feet;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefensePointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 5;
        private const int DefaultAttackRadiusBuff = 0;

        public Boots()
        {
            this.Name = DefaultName;
            this.Slot = DefaultSlot;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefensePointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.AttackRadiusBuff = DefaultAttackRadiusBuff;
        }
    }
}
