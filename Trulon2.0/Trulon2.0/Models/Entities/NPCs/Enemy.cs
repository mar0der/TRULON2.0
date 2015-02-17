namespace Trulon.Models.Entities.NPCs
{
    public abstract class Enemy : NonPlayerCharacter
    {
        public int ExperienceReward { get; set; }

        public int CoinsReward { get; set; }

        protected override void Move()
        {
            //TODO: AI for eneimies
        }

        public override void Update()
        {
            base.Update();

            if (this.BaseHealth <= 0)
            {
                this.IsAlive = false;
            }
        }


    }
}
