using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Interfaces
{
    /// <summary>
    /// Ensures that given item effects expire in time
    /// </summary>
    interface ITimeoutable
    {
        /// <summary>
        /// The total ammount of Game Ticks that given effect will last
        /// </summary>
        int Timeout { get; set; }

        /// <summary>
        /// The current ammount of Game Ticks that are left 
        /// </summary>
        int Countdown { get; set; }

        /// <summary>
        /// If the cooldown
        /// </summary>
        bool HasTimedOut { get; set; }
    }
}
