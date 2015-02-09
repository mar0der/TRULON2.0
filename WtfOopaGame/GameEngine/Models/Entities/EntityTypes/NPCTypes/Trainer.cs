using GameEngine.Models.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Models.Entities.EntityTypes.NPCTypes
{
    public class Trainer : NonPlayingComputer
    {
        public Trainer()
        {
            this.Images = Assets.Trainer;
        }
        public IList<Skill> Skills { get; set; }
    }
}
