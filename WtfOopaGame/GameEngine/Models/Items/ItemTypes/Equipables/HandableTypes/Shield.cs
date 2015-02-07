namespace GameEngine.Models.Items.ItemTypes.Equipables.HandableTypes
{
    public class Shield : HandEquipment
    {
        public Shield()
        {
            this.Cost = Config.ShieldCost;
            this.LevelRequirement = Config.ShieldLevelRequirement;
            this.HealthEffect = Config.ShieldHealthEffect;
            this.DefenseEffect = Config.ShieldDefenseEffect;
            this.AttackEffect = Config.ShieldAttackEffect;
            this.AttackSpeedEffect = Config.ShieldAttackSpeedEffect;
            this.Description = Config.ShieldDescription;
        }
    }
}
