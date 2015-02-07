namespace GameEngine.Models.Items.ItemTypes.Potions
{
    class DamagePotion : Potion
    {
        public DamagePotion()
        {
            this.Cost = Config.DemagePotionCost;
            this.LevelRequirement = Config.DemagePotionLevelRequirement;
            this.HealthEffect = Config.DemagePotionHealthEffect;
            this.DefenseEffect = Config.DemagePotionDefenseEffect;
            this.AttackEffect = Config.DemagePotionAttackEffect;
            this.AttackSpeedEffect = Config.DemagePotionAttackSpeedEffect;
            this.Description = Config.DemagePotionDescription;
            this.Timeout = Config.DemagePotionTimeout;
            this.Countdown = Config.DemagePotionCountdown;
            this.HasTimedOut = Config.DemagePotionHasTimedOut;
        }
    }
}
