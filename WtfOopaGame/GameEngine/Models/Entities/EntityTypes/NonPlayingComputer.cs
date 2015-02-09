using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Models.Entities.EntityTypes
{
    public abstract class NonPlayingComputer : Entity
    {
        //Implement show interaction button 
        public override void Update(Enums.Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
