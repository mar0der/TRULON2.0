using System.Collections.Generic;
using GameEngine.Models.Items;
using GameEngine.Models.Skills;

namespace GameEngine.Models.Entities.EntityTypes.FightingTypes
{
    abstract public class Player : FightingEntity
    {
        public PlayerEquipment Equipment { get; set; }

        public List<Item> Inventory { get; set; }

        public int Coins { get; set; }

        public List<Skill> Skills { get; set; }

        public override void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}