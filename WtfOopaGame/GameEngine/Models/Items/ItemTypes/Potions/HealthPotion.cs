namespace GameEngine.Models.Items.ItemTypes.Potions
{
    public class HealthPotion : Potion
    {
        public HealthPotion()
        {
            this.Cost = Config.HealthPotionCost;
            this.LevelRequirement = Config.HealthPotionLevelRequirement;
            this.HealthEffect = Config.HealthPotionHealthEffect;
            this.DefenseEffect = Config.HealthPotionDefenseEffect;
            this.AttackEffect = Config.HealthPotionAttackEffect;
            this.AttackSpeedEffect = Config.HealthPotionAttackSpeedEffect;
            this.Description = Config.HealthPotionDescription;
            this.Timeout = Config.HealthPotionTimeout;
            this.Countdown = Config.HealthPotionCountdown;
            this.HasTimedOut = Config.HealthPotionHasTimedOut;
        }
    }
}