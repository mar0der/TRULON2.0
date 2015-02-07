namespace GameEngine.Models.Items.ItemTypes.Equipables.HandableTypes
{
    public class Sword : HandEquipment
    {
        public Sword()
        {
            this.Cost = Config.SwordCost;
            this.LevelRequirement = Config.SwordLevelRequirement;
            this.HealthEffect = Config.SwordHealthEffect;
            this.DefenseEffect = Config.SwordDefenseEffect;
            this.AttackEffect = Config.SwordAttackEffect;
            this.AttackSpeedEffect = Config.SwordAttackSpeedEffect;
            this.Description = Config.SwordDescription;
        }

    }
}