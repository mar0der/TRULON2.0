namespace GameEngine.Models
{
    public abstract class Entity : GameObject
    {
        public int AttackPoints { get; set; }

        public int DefencePoints { get; set; }

        public int HealthPoints { get; set; }

        public int Level { get; set; }

        //protected abstract void Interact();

    }
}
