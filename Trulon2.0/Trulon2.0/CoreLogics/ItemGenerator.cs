using Trulon.Models.Items;

namespace Trulon.CoreLogics
{
    using System;
    using global::Trulon.Models;
    using global::Trulon.Models.Items.Equipments;
    using global::Trulon.Models.Items.Potions;

    public static class ItemGenerator
    {
        private static Random rand = new Random();

        public static Item GetEquipmentItem(Item[] equipments)
        {
            switch (rand.Next(0, equipments.Length))
            {
                case 0:
                    return equipments[0];
                    break;
                case 1:
                    return equipments[1];
                    break;
                case 2:
                    return equipments[2];
                    break;
                case 3:
                    return equipments[3];
                    break;
                case 4: 
                    return equipments[4];
                    break;
                default:
                    throw new Exception("Something went wrong in Item Generator");
                    break;
            }
        }

        public static Item GetPotionItem(Item[] potions)
        {
            switch (rand.Next(0, potions.Length))
            {
                case 0:
                    return potions[0];
                    break;
                case 1:
                    return potions[1];
                    break;
                case 2:
                    return potions[2];
                    break;
                case 3:
                    return potions[3];
                    break;
                default:
                    throw new Exception("Something went wrong in Item Generator");
                    break;
            }
        }
    }
}
