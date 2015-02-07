using System;

namespace GameEngine.Models.Items.ItemTypes
{
    public abstract class Equipment : Item
    {
        public override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
