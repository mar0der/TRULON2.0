using GameEngine.Models.Entities.EntityTypes.FightingTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Enums;
using GameEngine.Models.Entities.EntityTypes.FightingTypes.PlayerTypes;

namespace GameEngine.CoreLogic
{
    public static class PlayerManager
    {
        /// <summary>
        /// Prompts the user to create a Player
        /// </summary>
        /// <returns>New player instanse</returns>
        internal static Player GetPlayer()
        {
            //To Do: Ask for a player type!
            var type = PlayerType.Paladin;
            Player player;

            switch (type)
            {
                case PlayerType.Paladin:
                    player = new Paladin();
                    break;
                case PlayerType.Barbarian:
                    player = new Barbarian();
                    break;
                default:
                    throw new InvalidEnumArgumentException(type + "is not a correct type!");
            }

            return player;
        }
    }
}
