using System.Collections.Generic;
namespace GameEngine.Models.Entities.EntityTypes.FightingTypes.PlayerTypes
{
    public class Paladin : Player
    {
        public Paladin()
        {
            this.Coins = Config.InitialCoins;
            //this.Equipment = new List<PlayerEquipment>();
            //this.Inventory = new List<Items>();
            //this.Skills = new List<Skills>();
            this.RangeRadius = Config.PaladinRange;
            this.AttackPoints = Config.PaladinAttackPoints;
            this.DefensePoints = Config.PaladinDefensePoints;
            this.HealthPoints = Config.PaladinHealthPoints;
            this.AttackSpeed = Config.PaladinAttackSpeed;
            this.Level = Config.PaladinLevel;
            this.Images = Assets.PaladinImages;
        }
    }
}