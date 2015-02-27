namespace Trulon
{
    using System;
    using System.Windows.Forms;

    using global::Trulon.CoreLogics;
    using global::Trulon.Exceptions;

    /// <summary>
    /// The main class.
    /// </summary>
    public static class Trulon
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                using (var stateManager = new StateManager())
                {
                    stateManager.Run();
                }
            }
            catch (ResourcesNotFoundException re)
            {
                MessageBox.Show(re.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
