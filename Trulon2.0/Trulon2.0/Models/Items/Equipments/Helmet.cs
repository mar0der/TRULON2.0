namespace Trulon.Models.Items.Equipments
{
    using global::Trulon.Enums;

    public class Helmet : Equipment
    {
        private const string DefaultName = "Helmet";
        private const EquipmentSlots DefaultSlot = EquipmentSlots.Head;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefensePointsBuff = 10;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultAttackRadiusBuff = 0;

        public Helmet()
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
