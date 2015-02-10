namespace GameEngine.Models.Entities.EntityTypes.FightingTypes.PlayerTypes
{
    public class Barbarian : Player
    {
        public Barbarian()
        {
            this.Coins = Config.InitialCoins;
            //this.Equipment = new List<PlayerEquipment>();
            //this.Inventory = new List<Items>();
            //this.Skills = new List<Skills>();
            this.RangeRadius = Config.BarbarianRange;
            this.AttackPoints = Config.BarbarianAttackPoints;
            this.DefensePoints = Config.BarbarianDefensePoints;
            this.HealthPoints = Config.BarbarianHealthPoints;
            this.AttackSpeed = Config.BarbarianAttackSpeed;
            this.Level = Config.BarbarianLevel;
            this.Images = Assets.BarbarianImages;
        }
    }
}