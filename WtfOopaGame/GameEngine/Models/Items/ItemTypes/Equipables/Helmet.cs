namespace GameEngine.Models.Items.ItemTypes.Equipables
{
    public class Helmet : Equipment
    {
        public Helmet(){
            this.Cost = Config.HelmetCost;
            this.LevelRequirement = Config.HelmetLevelRequirement;
            this.HealthEffect = Config.HelmetHealthEffect;
            this.DefenseEffect = Config.HelmetDefenseEffect;
            this.AttackEffect = Config.HelmetAttackEffect;
            this.AttackSpeedEffect = Config.HelmetAttackSpeedEffect;
            this.Description = Config.HelmetDescription;
        }
        
    }
}
