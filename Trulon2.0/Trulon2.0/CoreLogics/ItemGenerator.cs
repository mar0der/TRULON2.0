using Trulon.Models;
using Trulon.Models.Items.Equipments;
using Trulon.Models.Items.Potions;

namespace Trulon.CoreLogics
{
    using System;
    static class  ItemGenerator
    {
        private static Random rand = new Random();
        public static Item GetEquipmentItem()
        {
            switch (rand.Next(0,3))
            {
                case 0:
                    return new Boots();
                    break;
                case 1:
                    return new Helmet();
                    break;
                case 2:
                    return new Vest();
                    break;
                default:
                    throw new Exception("Something went wrong in Item Generator");
                    break;
            }
        }

        public static Item GetPotionItem()
        {
                        switch (rand.Next(0,3))
            {
                case 0:
                    return new DamagePotion();
                    break;
                case 1:
                    return new DefencePotion();
                    break;
                case 2:
                    return new HealthPotion();
                    break;
                case 3:
                    return new SpeedPotion();
                    break;
                default:
                    throw new Exception("Something went wrong in Item Generator");
                    break;
            }
        }
    }
}
