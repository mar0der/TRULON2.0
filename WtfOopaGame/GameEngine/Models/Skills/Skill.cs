using GameEngine.Interfaces;

namespace GameEngine.Models.Skills
{
    public abstract class Skill : GameObject, ICastable, ITimeoutable
    {
        public abstract void Cast();

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
