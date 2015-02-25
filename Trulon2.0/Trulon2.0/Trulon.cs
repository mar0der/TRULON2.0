using System.Security.Cryptography.X509Certificates;

namespace Trulon
{
    using System;
    using global::Trulon.CoreLogics;

    /// <summary>
    /// The main class.
    /// </summary>
    public static class Trulon
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var game = new Engine())
            //{
            //    game.Run();
            //}
            using (var stateManager = new StateManager())
            {
                stateManager.Run();
            }
        }
    }
}
