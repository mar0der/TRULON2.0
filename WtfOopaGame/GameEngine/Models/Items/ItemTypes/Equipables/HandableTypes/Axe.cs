namespace GameEngine.Models.Items.ItemTypes.Equipables.HandableTypes
{
    public class Axe : HandEquipment
    {
        public Axe()
        {
            this.Cost = Config.AxeCost;
            this.LevelRequirement = Config.AxeLevelRequirement;
            this.HealthEffect = Config.AxeHealthEffect;
            this.DefenseEffect = Config.AxeDefenseEffect;
            this.AttackEffect = Config.AxeAttackEffect;
            this.AttackSpeedEffect = Config.AxeAttackSpeedEffect;
            this.Description = Config.AxeDescription;
        }
    }
}
