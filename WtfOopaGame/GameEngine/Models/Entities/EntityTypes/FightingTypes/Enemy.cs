namespace GameEngine.Models.Entities.EntityTypes.FightingTypes
{
    public abstract class Enemy : FightingEntity
    {
        public bool IsAttacked { get; set; }

        public override void Die()
        {
            //Generate
            throw new System.NotImplementedException();
        }
    }
}