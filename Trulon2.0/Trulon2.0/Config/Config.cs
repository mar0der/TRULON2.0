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

        public const int TotalItemsCount = 10;

        //controls
        public static readonly Keys[] UseItemKeys = { Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5 };
        public static readonly Keys[] DumpItemFromInvontoryKeys = { Keys.Q, Keys.W, Keys.E, Keys.R, Keys.T};
        //Keys sequence "head" , "Left Hand", "Right Hand", "body", "Feet"
        public static readonly Keys[] DeequipItemKeys = {Keys.Z, Keys.X, Keys.C, Keys.V, Keys.B};
        //Keys for buying stuff
        public static readonly Keys[] BuyItemKeys = { Keys.A, Keys.S, Keys.D, Keys.F, Keys.G, Keys.H, Keys.J, Keys.K, Keys.L, Keys.M };
        //GUI settings
        public const int CnventoryIsFullMessageTimeout = 300;

    }
}