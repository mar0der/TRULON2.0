namespace Trulon.Models
{
    using global::Trulon.Structs;

    public abstract class Map : GameObject
    {
        public virtual Obsticle[] Obsticles { get; set; }
    }
}
