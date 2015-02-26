namespace Trulon.Config
{
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    /// Contains all constants
    /// </summary>
    public static class Config
    {
        public const int NumberOfLevels = 5;
        //Screen size
        public const int ScreenWidth = 1280;
        public const int ScreenHeight = 720;

        //Players base constatnts
        public const int InventorySize = 5;
        public const int InitialCoins = 100;

        public const int TotalItemsCount = 9;

        //controls
        public static readonly Keys[] UseItemKeys = { Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5 };
        public static readonly Keys[] DropItemFromInventoryKeys = { Keys.Q, Keys.W, Keys.E, Keys.R, Keys.T };
        //Keys sequence "head" , "Left Hand", "Right Hand", "body", "Feet"
        public static readonly Keys[] UnequipItemKeys = { Keys.Z, Keys.X, Keys.C, Keys.V, Keys.B };
        //Keys for buying stuff
        public static readonly Keys[] BuyItemKeys = { Keys.A, Keys.S, Keys.D, Keys.F, Keys.G, Keys.H, Keys.J, Keys.K, Keys.L };
        //GUI settings
        public const int InventoryIsFullMessageTimeout = 300;

    }
}