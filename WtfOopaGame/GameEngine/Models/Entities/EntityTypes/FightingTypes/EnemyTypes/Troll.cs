namespace GameEngine.Models.Entities.EntityTypes.FightingTypes.EnemyTypes
{
    class Troll : Enemy
    {
        public Troll()
        {
            this.RangeRadius = Config.TrollRange;
            this.AttackPoints = Config.TrollAttackPoints;
            this.DefensePoints = Config.TrollDefensePoints;
            this.HealthPoints = Config.TrollHealthPoints;
            this.AttackSpeed = Config.TrollAttackSpeed;
            this.Level = Config.TrollLevel;
            this.IsAlive = true;
            this.Images = Assets.TrollImages;
        }
    }
}
