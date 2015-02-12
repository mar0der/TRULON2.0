namespace GameEngine.Models.Items.Equipments
{
    public class Vest : Equipment
    {
        public Vest(string name) 
            : base(name)
        {
            //this.DefensePointsBuff = Config;
        }

        public int DefensePointsBuff { get; set; }
    }
}
