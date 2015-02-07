namespace GameEngine.Models.Items.ItemTypes.Equipables
{
    public class Pants : Equipment
    {
        public Pants()
        {
            this.Cost = Config.PantsCost;
            this.LevelRequirement = Config.PantsLevelRequirement;
            this.HealthEffect = Config.PantsHealthEffect;
            this.DefenseEffect = Config.PantsDefenseEffect;
            this.AttackEffect = Config.PantsAttackEffect;
            this.AttackSpeedEffect = Config.PantsAttackSpeedEffect;
            this.Description = Config.PantsDescription;
        }
    }
}
