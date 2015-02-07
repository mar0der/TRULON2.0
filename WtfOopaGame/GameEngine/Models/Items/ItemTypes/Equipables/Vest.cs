namespace GameEngine.Models.Items.ItemTypes.Equipables
{
    public class Vest : Equipment
    {
        public Vest()
        {
            this.Cost = Config.VestCost;
            this.LevelRequirement = Config.VestLevelRequirement;
            this.HealthEffect = Config.VestHealthEffect;
            this.DefenseEffect = Config.VestDefenseEffect;
            this.AttackEffect = Config.VestAttackEffect;
            this.AttackSpeedEffect = Config.VestAttackSpeedEffect;
            this.Description = Config.VestDescription;
        }
    }
}
