namespace GameEngine.Models.Entities.EntityTypes.FightingTypes.EnemyTypes
{
    public class Orc : Enemy
    {
        public Orc()
        {
            this.Range = Config.OrcRange;
            this.AttackPoints = Config.OrcAttackPoints;
            this.DefensePoints = Config.OrcDefensePoints;
            this.HealthPoints = Config.OrcHealthPoints;
            this.AttackSpeed = Config.OrcAttackSpeed;
            this.Level = Config.OrcLevel;
            this.IsAlive = true;
            this.Images = Assets.OrcImages;
        }
    }
}