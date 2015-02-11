namespace GameEngine.Models.Entities
{
    public abstract class Player : Entity
    {
        public int Experience { get; set; }

        public int Coins { get; set; }

        public int SkillPoints { get; set; }

        public int AttackSkill { get; set; }

        public int HealthSkill { get; set; }

        public int DefenceSkill { get; set; }

        public Player()
        {
            
        }
        
        //protected abstract void AddExperience();

        //protected abstract void AddCoins();

        //protected abstract void AddSkillPoints();

    }
}
