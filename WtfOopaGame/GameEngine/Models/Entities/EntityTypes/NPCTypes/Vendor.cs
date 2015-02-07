using GameEngine.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Models.Entities.EntityTypes.NPCTypes
{
    public class Vendor : NonPlayingComputer
    {
        public IList<Item> Items { get; set; }
    }
}
