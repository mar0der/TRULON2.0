using System.Linq;

namespace Trulon.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;
    using Enums;
    using NPCs;
    using Items;
    using Items.Potions;
    using Config;

    public abstract class Player : Entity
    {
        private KeyboardState currentKeyboardState;
        private int velocityUp;
        private int velocityDown;
        private int velocityLeft;
        private int velocityRight;
        private IList<Potion> activePotions = new List<Potion>();
        private int inventoryIsFullTimeout;

        public EntityEquipment PlayerEquipment { get; set; }

        public IList<Potion> ActivePotions
        {
            get
            {
                return this.activePotions;

            }
        }

        public int Experience { get; set; }

        public int Coins { get; set; }

        public int SkillPoints { get; set; }

        public int AttackSkill { get; set; }

        public int DefenseSkill { get; set; }

        public int SpeedSkill { get; set; }

        public int HealthSkill { get; set; }

        public int AttackPoints
        {
            get
            {
                return this.BaseAttack + this.EquipmentBuffs["attack"] + this.AttackSkill + this.PotionBuffs["Attack"];
            }
        }

        public int DefensePoints
        {
            get
            {
                return this.BaseDefense + this.EquipmentBuffs["defense"] + this.DefenseSkill + this.PotionBuffs["Defense"];
            }
        }

        public int SpeedPoints
        {
            get
            {
                return this.BaseSpeed + this.EquipmentBuffs["speed"] + this.SpeedSkill + this.PotionBuffs["Speed"];
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.BaseHealth + this.HealthSkill + this.PotionBuffs["Health"];
            }
        }

        public override int AttackRadius
        {
            get
            {
                return this.BaseAttackRadius + this.EquipmentBuffs["attackRange"];
            }
        }

        public Dictionary<string, int> EquipmentBuffs
        {
            get
            {
                var buffs = new Dictionary<string, int>();
                int attackBuff = 0;
                int defenseBuff = 0;
                int speedBuff = 0;
                int attackRange = 0;

                foreach (var item in this.PlayerEquipment.CurrentEquipment)
                {
                    //because the item can be removed form equipment and the slot will be set to null
                    if (item.Value != null)
                    {
                        attackBuff += item.Value.AttackPointsBuff;
                        defenseBuff += item.Value.DefensePointsBuff;
                        speedBuff += item.Value.SpeedPointsBuff;
                        attackRange += item.Value.AttackRadiusBuff; 
                    }
                }
                buffs.Add("attack", attackBuff);
                buffs.Add("defense", defenseBuff);
                buffs.Add("speed", speedBuff);
                buffs.Add("attackRange", attackRange);
                return buffs;
            }
        }

        public Dictionary<string, int> PotionBuffs
        {
            get
            {
                var buffs = new Dictionary<string, int>();
                int attackBuff = 0;
                int defenseBuff = 0;
                int speedBuff = 0;
                int healthBuff = 0;

                foreach (var potion in this.ActivePotions)
                {
                    if (potion is DamagePotion)
                    {
                        attackBuff += potion.AttackPointsBuff;
                    }
                    else if (potion is DefensePotion)
                    {
                        defenseBuff += potion.DefensePointsBuff;
                    }
                    else if (potion is SpeedPotion)
                    {
                        speedBuff += potion.SpeedPointsBuff;
                    }
                    else if (potion is HealthPotion)
                    {
                        healthBuff += potion.HealthPointsBuff;
                    }
                }

                buffs.Add("Attack", attackBuff);
                buffs.Add("Health", healthBuff);
                buffs.Add("Defense", defenseBuff);
                buffs.Add("Speed", speedBuff);
                return buffs;
            }
        }

        public bool  inventoryIsFull {
            get
            {
                if (inventoryIsFullTimeout > 0)
                {
                    inventoryIsFullTimeout--;
                    return true;
                }
                return false;
            }
        }

        public void Update(Map map)
        {
            base.Update();
            this.Move(map);
            //Keyboard input is in the move method which is called in the base update method
            //Make sure that player doesn't go out of bounds. T
            this.Position = new Vector2(
                MathHelper.Clamp(this.Position.X, 0, Config.ScreenWidth - this.Image.Width),
                MathHelper.Clamp(this.Position.Y, 0, Config.ScreenHeight - this.Image.Height));

            //check for timeouted potions
            for (int i = 0; i < activePotions.Count; i++)
            {
                if (activePotions[i].Countdown == 0)
                {
                    this.activePotions.Remove(activePotions[i]);
                    break;
                }
                activePotions[i].Countdown--;
            }
        }

        public IList<Enemy> GetEnemiesInRange(IList<Enemy> enemies)
        {
            var enemiesInRange = new List<Enemy>();

            foreach (var enemy in enemies)
            {
                if (this.AttackBounds.Intersects(enemy.Bounds))
                {
                    enemiesInRange.Add(enemy);
                }
            }
            return enemiesInRange;
        }

        public Ally GetAllyInRange(IList<Entity> entities)
        {
            foreach (var entity in entities)
            {
                if (this.Bounds.Intersects(entity.Bounds) && entity is Ally)
                {
                    return (Ally)entity;
                }
            }
            return null;
        }

        public void Attack(IList<Enemy> enemiesInRange)
        {
            foreach (var enemy in enemiesInRange)
            {
                enemy.HealthPoints -= this.AttackPoints;
            }
        }

        public void AddExperience(Enemy enemy)
        {
            this.Experience += enemy.ExperienceReward;
        }

        public void AddCoins(Enemy enemy)
        {
            this.Coins += enemy.CoinsReward;
        }

        public void Buy()
        {
            throw new NotImplementedException("Buy method is not implemented");
        }

        protected internal void DrinkPotion(int itemAtIndex)
        {
            if (this.Inventory.ElementAt(itemAtIndex) is Potion)
            {
                this.ActivePotions.Add(this.Inventory.ElementAt(itemAtIndex) as Potion);
                this.Inventory[itemAtIndex] = null;
            }
        }

        public void UseEquipment(int itemAtIndex)
        {
            if (itemAtIndex < this.Inventory.Length && this.Inventory[itemAtIndex] is Equipment)
            {
                var equipment = this.Inventory[itemAtIndex] as Equipment;
                //It is a bit hard to read. It means. If the key does not exists or if it is exists and the value is null
                if (!this.PlayerEquipment.CurrentEquipment.ContainsKey(equipment.Slot) ||
                    (this.PlayerEquipment.CurrentEquipment.ContainsKey(equipment.Slot) 
                    && this.PlayerEquipment.CurrentEquipment[equipment.Slot] == null))
                {
                    this.PlayerEquipment.CurrentEquipment[equipment.Slot] = equipment;
                    this.Inventory[itemAtIndex] = null;
                }
            }
        }

        public void DeequipItem(EquipmentSlots slot)
        {
            if (!this.IsInventoryFull())
            {
                if (this.PlayerEquipment.CurrentEquipment.ContainsKey(slot) && this.PlayerEquipment.CurrentEquipment[slot] != null)
                {
                    this.AddToInventory(this.PlayerEquipment.CurrentEquipment[slot]);
                    this.PlayerEquipment.CurrentEquipment[slot] = null;
                }
            }
            else
            {
                this.inventoryIsFullTimeout = Config.CnventoryIsFullMessageTimeout;
            }
        }

        public bool IsInventoryFull()
        {
            bool isFull = true;
            for (int i = 0; i < this.Inventory.Length; i++)
            {
                if (this.Inventory[i] == null)
                {
                    isFull = false;
                    break;
                }
            }
            return isFull;
        }

        public void DumpItem(int itemAtIndex)
        {
            if (itemAtIndex < this.Inventory.Length)
            {
                this.Inventory[itemAtIndex] = null;
            }
        }

        protected void AddSkillPoints()
        {
            throw new NotImplementedException("Buy method is not implemented");
        }

        protected void Move(Map map)
        {
            currentKeyboardState = Keyboard.GetState();

            velocityUp = SpeedPoints;
            velocityDown = SpeedPoints;
            velocityLeft = SpeedPoints;
            velocityRight = SpeedPoints;

            foreach (var obsticle in map.Obsticles)
            {
                if (this.Bounds.Intersects(obsticle.ObsticleBox))
                {
                    if (obsticle.RestrictedDirection == Direction.Up)
                    {
                        velocityUp = 0;
                    }
                    if (obsticle.RestrictedDirection == Direction.Down)
                    {
                        velocityDown = 0;
                    }
                    if (obsticle.RestrictedDirection == Direction.Left)
                    {
                        velocityLeft = 0;
                    }
                    if (obsticle.RestrictedDirection == Direction.Right)
                    {
                        velocityRight = 0;
                    }
                }
            }

            if (currentKeyboardState.IsKeyDown(Keys.Left))
            {
                this.Position = new Vector2(this.Position.X - this.velocityLeft, this.Position.Y);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Right))
            {
                this.Position = new Vector2(this.Position.X + this.velocityRight, this.Position.Y);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Up))
            {
                this.Position = new Vector2(this.Position.X, this.Position.Y - this.velocityUp);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Down))
            {
                this.Position = new Vector2(this.Position.X, this.Position.Y + this.velocityDown);
            }
        }

        public void AddToInventory(Item item)
        {
            bool isAdded = false;
            for (int i = 0; i < this.Inventory.Length; i++)
            {
                if (this.Inventory.ElementAt(i) == null)
                {
                    isAdded = true;
                    this.Inventory[i] = item;
                    break;
                }
            }
            if (!isAdded)
            {
                this.inventoryIsFullTimeout = Config.CnventoryIsFullMessageTimeout;
            }
        }
    }
}
