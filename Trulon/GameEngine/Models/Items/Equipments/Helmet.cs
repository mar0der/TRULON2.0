namespace GameEngine.Models.Items.Equipments
{
    public class Helmet : Equipment
    {
        public Helmet(string name) 
            : base(name)
        {
            //this.DefensePointsBuff = Config ;
        }

        public int DefensePointsBuff { get; set; }
    }
}
