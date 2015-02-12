namespace GameEngine.Config
{
    /// <summary>
    /// Contains all constants
    /// </summary>
    public static class Config
    {
        //Players base constatnts
        public static readonly int InventorySize = 20;
        public static readonly int InitialCoins = 100;
        //Barbarian base constants
        public static readonly int BarbarianRange = 100;
        public static readonly int BarbarianAttackPoints = 10;
        public static readonly int BarbarianDefensePoints = 10;
        public static readonly int BarbarianHealthPoints = 100;
        public static readonly int BarbarianAttackSpeed = 50;
        public static readonly int BarbarianLevel = 1;
        //Paladin base constants
        public static readonly int PaladinRange = 100;
        public static readonly int PaladinAttackPoints = 10;
        public static readonly int PaladinDefensePoints = 10;
        public static readonly int PaladinHealthPoints = 100;
        public static readonly int PaladinAttackSpeed = 50;
        public static readonly int PaladinLevel = 1;
        //Goblin base constants
        public static readonly int GoblinRange = 100;
        public static readonly int GoblinAttackPoints = 10;
        public static readonly int GoblinDefensePoints = 10;
        public static readonly int GoblinHealthPoints = 100;
        public static readonly int GoblinAttackSpeed = 50;
        public static readonly int GoblinLevel = 1;
        //Orc base constants
        public static readonly int OrcRange = 100;
        public static readonly int OrcAttackPoints = 10;
        public static readonly int OrcDefensePoints = 10;
        public static readonly int OrcHealthPoints = 100;
        public static readonly int OrcAttackSpeed = 50;
        public static readonly int OrcLevel = 1;
        //Troll base constants
        public static readonly int TrollRange = 100;
        public static readonly int TrollAttackPoints = 10;
        public static readonly int TrollDefensePoints = 10;
        public static readonly int TrollHealthPoints = 100;
        public static readonly int TrollAttackSpeed = 50;
        public static readonly int TrollLevel = 1;
        //Items
        //Boots
        public static readonly int BootsCost = 10;
        public static readonly int BootsLevelRequirement = 2;
        public static readonly int BootsHealthEffect = 1;
        public static readonly int BootsDefenseEffect = 7;
        public static readonly int BootsAttackEffect = 0;
        public static readonly int BootsAttackSpeedEffect = 30;
        public static readonly string BootsDescription = "Very fast boots";
        //Helmet
        public static readonly int HelmetCost = 15;
        public static readonly int HelmetLevelRequirement = 3;
        public static readonly int HelmetHealthEffect = 5;
        public static readonly int HelmetDefenseEffect = 10;
        public static readonly int HelmetAttackEffect = 0;
        public static readonly int HelmetAttackSpeedEffect = 30;
        public static readonly string HelmetDescription = "Strong helmet";
        //Pants
        public static readonly int PantsCost = 20;
        public static readonly int PantsLevelRequirement = 4;
        public static readonly int PantsHealthEffect = 15;
        public static readonly int PantsDefenseEffect = 10;
        public static readonly int PantsAttackEffect = 0;
        public static readonly int PantsAttackSpeedEffect = 30;
        public static readonly string PantsDescription = "Iron pants";
        //Vest
        public static readonly int VestCost = 25;
        public static readonly int VestLevelRequirement = 5;
        public static readonly int VestHealthEffect = 25;
        public static readonly int VestDefenseEffect = 10;
        public static readonly int VestAttackEffect = 0;
        public static readonly int VestAttackSpeedEffect = 10;
        public static readonly string VestDescription = "Very strong vest";
        //Hand items
        //Axe
        public static readonly int AxeCost = 15;
        public static readonly int AxeLevelRequirement = 2;
        public static readonly int AxeHealthEffect = 0;
        public static readonly int AxeDefenseEffect = 0;
        public static readonly int AxeAttackEffect = 15;
        public static readonly int AxeAttackSpeedEffect = 15;
        public static readonly string AxeDescription = "Brutal Axe";
        //Shield
        public static readonly int ShieldCost = 20;
        public static readonly int ShieldLevelRequirement = 3;
        public static readonly int ShieldHealthEffect = 0;
        public static readonly int ShieldDefenseEffect = 20;
        public static readonly int ShieldAttackEffect = 0;
        public static readonly int ShieldAttackSpeedEffect = 0;
        public static readonly string ShieldDescription = "Big shield";
        //Sword
        public static readonly int SwordCost = 20;
        public static readonly int SwordLevelRequirement = 4;
        public static readonly int SwordHealthEffect = 0;
        public static readonly int SwordDefenseEffect = 0;
        public static readonly int SwordAttackEffect = 30;
        public static readonly int SwordAttackSpeedEffect = 5;
        public static readonly string SwordDescription = "Mega Sword";
        //Timeoutable Items
        //DemagePotion
        public static readonly int DemagePotionCost = 10;
        public static readonly int DemagePotionLevelRequirement = 1;
        public static readonly int DemagePotionHealthEffect = 0;
        public static readonly int DemagePotionDefenseEffect = 0;
        public static readonly int DemagePotionAttackEffect = 10;
        public static readonly int DemagePotionAttackSpeedEffect = 50;
        public static readonly string DemagePotionDescription = "Drink it and you will hit harder";
        public static readonly int DemagePotionTimeout = 30;
        public static readonly int DemagePotionCountdown = 30;
        public static readonly bool DemagePotionHasTimedOut = false;
        //HealthPotion
        public static readonly int HealthPotionCost = 10;
        public static readonly int HealthPotionLevelRequirement = 1;
        public static readonly int HealthPotionHealthEffect = 100;
        public static readonly int HealthPotionDefenseEffect = 0;
        public static readonly int HealthPotionAttackEffect = 0;
        public static readonly int HealthPotionAttackSpeedEffect = 50;
        public static readonly string HealthPotionDescription = "Drink it and you get 100 extra hitpoints";
        public static readonly int HealthPotionTimeout = 30;
        public static readonly int HealthPotionCountdown = 30;
        public static readonly bool HealthPotionHasTimedOut = false;
    }
}
