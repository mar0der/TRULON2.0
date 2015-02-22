namespace Trulon.Config
{
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    /// Contains all constants
    /// </summary>
    public static class Config
    {
        //Screen size
        public const int ScreenWidth = 1280;
        public const int ScreenHeight = 720;

        //Players base constatnts
        public const int InventorySize = 5;
        public const int InitialCoins = 100;

        public const int TotalItemsCount = 8;

        //controls
        public static readonly Keys[] UseItemKeys = { Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5 };
        public static readonly Keys[] DumpItemFromInvontory = { Keys.Q, Keys.W, Keys.E, Keys.R, Keys.T};
    }
}