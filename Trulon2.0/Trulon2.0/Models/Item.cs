namespace Trulon.Models
{
    using global::Trulon.Interfaces;

    public abstract class Item : GameObject, IItem
    {

        public virtual int SpeedPointsBuff { get; set; }

        public virtual int DefensePointsBuff { get; set; }

        public virtual int AttackPointsBuff { get; set; }

        public virtual int HealthPointsBuff { get; set; }
        
        public virtual int Price { get; set; }
    }
}
