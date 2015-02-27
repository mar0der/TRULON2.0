namespace Trulon.CoreLogics
{
    using System;
    using global::Trulon.Models;

    public static class ItemGenerator
    {
        private static readonly Random Rand = new Random();

        public static Item GetEquipmentItem(Item[] equipments)
        {
            switch (Rand.Next(0, equipments.Length))
            {
                case 0:
                    return equipments[0];
                case 1:
                    return equipments[1];
                case 2:
                    return equipments[2];
                case 3:
                    return equipments[3];
                case 4: 
                    return equipments[4];
                default:
                    throw new Exception("Something went wrong in Item Generator");
            }
        }

        public static Item GetPotionItem(Item[] potions)
        {
            switch (Rand.Next(0, potions.Length))
            {
                case 0:
                    return potions[0];
                case 1:
                    return potions[1];
                case 2:
                    return potions[2];
                case 3:
                    return potions[3];
                default:
                    throw new Exception("Something went wrong in Item Generator");
            }
        }
    }
}
