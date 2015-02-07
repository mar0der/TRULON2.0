namespace GameEngine.Models.Items.ItemTypes.Equipables
{
    public class Boots : Equipment
    {
        public Boots()
        {
            this.Cost = Config.BootsCost;
            this.LevelRequirement = Config.BootsLevelRequirement;
            this.HealthEffect = Config.BootsHealthEffect;
            this.DefenseEffect = Config.BootsDefenseEffect;
            this.AttackEffect = Config.BootsAttackEffect;
            this.AttackSpeedEffect = Config.BootsAttackSpeedEffect;
            this.Description = Config.BootsDescription;
        }
    }
}
