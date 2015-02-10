namespace GameEngine.Models.Entities.EntityTypes.FightingTypes.EnemyTypes
{
    class Goblin : Enemy
    {
        public Goblin()
        {
            this.RangeRadius = Config.GoblinRange;
            this.AttackPoints = Config.GoblinAttackPoints;
            this.DefensePoints = Config.GoblinDefensePoints;
            this.HealthPoints = Config.GoblinHealthPoints;
            this.AttackSpeed = Config.GoblinAttackSpeed;
            this.Level = Config.GoblinLevel;
            this.IsAlive = true;
            this.Images = Assets.GoblinImages;
        }
    }
}
