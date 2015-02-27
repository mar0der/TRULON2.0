namespace Trulon.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;
    using global::Trulon.Config;
    using global::Trulon.Enums;
    using global::Trulon.Models.Entities.NPCs;
    using global::Trulon.Models.Items;
    using global::Trulon.Models.Items.Potions;

    public abstract class Player : Entity
    {
        private readonly IList<Potion> activePotions = new List<Potion>();

        private KeyboardState currentKeyboardState;

        private int inventoryIsFullTimeout;

        private int healthPoints;

        public EntityEquipment PlayerEquipment { get; set; }

        public IList<Potion> ActivePotions
        {
            get { return this.activePotions; }
        }

        public int VelocityUp { get; set; }

        public int VelocityDown { get; set; }

        public int VelocityLeft { get; set; }

        public int VelocityRight { get; set; }

        public int Experience { get; set; }

        public int Coins { get; set; }

        public int AttackPoints
        {
            get
            {
                return this.BaseAttack + this.EquipmentBuffs["attack"] + this.PotionBuffs["Attack"];
            }
        }

        public int DefensePoints
        {
            get
            {
                return this.BaseDefense + this.EquipmentBuffs["defense"] + this.PotionBuffs["Defense"];
            }
        }

        public int SpeedPoints
        {
            get
            {
                return this.BaseSpeed + this.EquipmentBuffs["speed"] + this.PotionBuffs["Speed"];
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set 
            {
                if (value <= 0)
                {
                    this.IsAlive = false;
                }

                this.healthPoints = value;
            }
        }

        public virtual int CurrentMaxHealth { get; set; }

        public Dictionary<string, int> EquipmentBuffs
        {
            get
            {
                var buffs = new Dictionary<string, int>();
                int attackBuff = 0;
                int defenseBuff = 0;
                int speedBuff = 0;
                int healthBuff = 0;
                if (this.PlayerEquipment != null)
                {
                    foreach (var item in this.PlayerEquipment.CurrentEquipment)
                    {
                        // Because the item can be removed form equipment and the slot will be set to null
                        if (item.Value != null)
                        {
                            attackBuff += item.Value.AttackPointsBuff;
                            defenseBuff += item.Value.DefensePointsBuff;
                            speedBuff += item.Value.SpeedPointsBuff;
                            healthBuff += item.Value.HealthPointsBuff;
                        }
                    }

                    buffs.Add("attack", attackBuff);
                    buffs.Add("defense", defenseBuff);
                    buffs.Add("speed", speedBuff);
                    buffs.Add("health", healthBuff);
                    return buffs;
                }

                return null;
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

        public bool InventoryIsFull
        {
            get
            {
                if (this.inventoryIsFullTimeout > 0)
                {
                    this.inventoryIsFullTimeout--;
                    return true;
                }

                return false;
            }
        }

        public override int Level
        {
            get
            {
                int exp = this.Experience;
                if (exp >= 0 && exp < 300)
                {
                    return 1;
                }

                if (exp >= 300 && exp < 600)
                {
                    return 2;
                }

                if (exp >= 600 && exp < 900)
                {
                    return 3;
                }

                if (exp >= 900 && exp < 1200)
                {
                    return 4;
                }

                if (exp >= 1200 && exp < 1500)
                {
                    return 5;
                }

                return 6;
            }
        }

        public override void Update()
        {
            // Update bounds of player
            this.Bounds = new BoundingBox(new Vector3(this.Position.X, this.Position.Y + 64, 0), new Vector3(this.Position.X + this.Width, Position.Y + this.Height + 64, 0));

            this.Move();

            // Keyboard input is in the move method which is called in the base update method
            // Make sure that player doesn't go out of bounds. T
            this.Position = new Vector2(
                MathHelper.Clamp(this.Position.X, -64, Config.ScreenWidth - this.Image.Width + 64),
                MathHelper.Clamp(this.Position.Y, -80, Config.ScreenHeight - this.Image.Height + 80));

            // Check for timeouted potions
            for (int i = 0; i < this.activePotions.Count; i++)
            {
                if (this.activePotions[i].Countdown == 0)
                {
                    this.activePotions[i].ResetCountdown();
                    this.activePotions.Remove(this.activePotions[i]);
                    break;
                }

                this.activePotions[i].Countdown--;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                this.UpdateBoundsRight();
                this.previousDirection = Direction.Right;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                this.UpdateBoundsLeft();
                this.previousDirection = Direction.Left;
            }
            else
            {
                if (this.previousDirection == Direction.Right)
                {
                    this.UpdateBoundsRight();
                }
                else
                {
                    this.UpdateBoundsLeft();
                }
            }
        }

        public IList<Enemy> GetEnemiesInRange(IList<Enemy> enemies)
        {
            return enemies.Where(enemy => this.AttackBounds.Intersects(enemy.Bounds)).ToList();
        }

        public Ally GetAllyInRange(IList<Entity> entities)
        {
            return entities.Where(entity => this.AttackBounds.Intersects(entity.Bounds) && entity is Ally).Cast<Ally>().FirstOrDefault();
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

        public void UseEquipment(int itemAtIndex)
        {
            if (itemAtIndex < this.Inventory.Length && this.Inventory[itemAtIndex] is Equipment)
            {
                var equipment = this.Inventory[itemAtIndex] as Equipment;

                // It is a bit hard to read. It means. If the key does not exists or if it is exists and the value is null
                if (!this.PlayerEquipment.CurrentEquipment.ContainsKey(equipment.Slot) ||
                    (this.PlayerEquipment.CurrentEquipment.ContainsKey(equipment.Slot)
                    && this.PlayerEquipment.CurrentEquipment[equipment.Slot] == null))
                {
                    this.PlayerEquipment.CurrentEquipment[equipment.Slot] = equipment;
                    this.Inventory[itemAtIndex] = null;
                }
            }
        }

        public void UnequipItem(EquipmentSlots slot)
        {
            if (!this.IsInventoryFull())
            {
                if (this.PlayerEquipment.CurrentEquipment.ContainsKey(slot) &&
                    this.PlayerEquipment.CurrentEquipment[slot] != null)
                {
                    this.AddToInventory(this.PlayerEquipment.CurrentEquipment[slot]);
                    this.PlayerEquipment.CurrentEquipment[slot] = null;
                }
            }
            else
            {
                this.inventoryIsFullTimeout = Config.InventoryIsFullMessageTimeout;
            }
        }

        public bool IsInventoryFull()
        {
            return this.Inventory.All(t => t != null);
        }

        public void DropItem(int itemAtIndex)
        {
            if (itemAtIndex < this.Inventory.Length)
            {
                this.Inventory[itemAtIndex] = null;
            }
        }

        public bool Intersects(BoundingBox box)
        {
            return this.Bounds.Intersects(box);
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
                this.inventoryIsFullTimeout = Config.InventoryIsFullMessageTimeout;
            }
        }

        public void UseOrEquipFromInventory(Keys[] useItemKeys)
        {
            if (this.currentKeyboardState.GetPressedKeys().Length > 0 && useItemKeys.Contains(this.currentKeyboardState.GetPressedKeys()[0]))
            {
                int itemAtIndex = Array.IndexOf(useItemKeys, currentKeyboardState.GetPressedKeys()[0]);

                if (this.Inventory.ElementAt(itemAtIndex) is Potion)
                {
                    this.DrinkPotion(itemAtIndex);
                }
                else if (this.Inventory.ElementAt(itemAtIndex) is Equipment)
                {
                    this.UseEquipment(itemAtIndex);
                }
            }
        }

        public void DropItemFromInventory(Keys[] dropItemKeys)
        {
            if (this.currentKeyboardState.GetPressedKeys().Length > 0 && dropItemKeys.Contains(this.currentKeyboardState.GetPressedKeys()[0]))
            {
                int itemAtIndex = Array.IndexOf(dropItemKeys, this.currentKeyboardState.GetPressedKeys()[0]);
                this.DropItem(itemAtIndex);
            }
        }

        public void UnequipItem(Keys[] unequipItemKeys)
        {
            if (this.currentKeyboardState.GetPressedKeys().Length > 0 && unequipItemKeys.Contains(this.currentKeyboardState.GetPressedKeys()[0]))
            {
                var itemAtIndex = Array.IndexOf(unequipItemKeys, this.currentKeyboardState.GetPressedKeys()[0]);
                switch (itemAtIndex)
                {
                    case 0:
                        this.UnequipItem(EquipmentSlots.Head);
                        break;
                    case 1:
                        this.UnequipItem(EquipmentSlots.LeftHand);
                        break;
                    case 2:
                        this.UnequipItem(EquipmentSlots.RightHand);
                        break;
                    case 3:
                        this.UnequipItem(EquipmentSlots.Body);
                        break;
                    case 4:
                        this.UnequipItem(EquipmentSlots.Feet);
                        break;
                }
            }
        }

        public void ReSpawn(Vector2 position)
        {
            this.Position = new Vector2(position.X, position.Y);
        }

        protected internal void DrinkPotion(int itemAtIndex)
        {
            var item = this.Inventory.ElementAt(itemAtIndex);
            if (item is HealthPotion && this.HealthPoints < this.CurrentMaxHealth)
            {
                var newHealthPoints = this.HealthPoints + item.HealthPointsBuff;
                this.HealthPoints = newHealthPoints > this.CurrentMaxHealth ? this.CurrentMaxHealth : newHealthPoints;

                this.Inventory[itemAtIndex] = null;
            }
            else if (this.Inventory.ElementAt(itemAtIndex) is Potion &&
                !(this.Inventory.ElementAt(itemAtIndex) is HealthPotion))
            {
                this.ActivePotions.Add(this.Inventory.ElementAt(itemAtIndex) as Potion);
                this.Inventory[itemAtIndex] = null;
            }
        }
        
        protected override void Move()
        {
            this.currentKeyboardState = Keyboard.GetState();

            if (this.currentKeyboardState.IsKeyDown(Keys.Left))
            {
                this.Position = new Vector2(this.Position.X - this.VelocityLeft, this.Position.Y);
            }

            if (this.currentKeyboardState.IsKeyDown(Keys.Right))
            {
                this.Position = new Vector2(this.Position.X + this.VelocityRight, this.Position.Y);
            }

            if (this.currentKeyboardState.IsKeyDown(Keys.Up))
            {
                this.Position = new Vector2(this.Position.X, this.Position.Y - this.VelocityUp);
            }

            if (this.currentKeyboardState.IsKeyDown(Keys.Down))
            {
                this.Position = new Vector2(this.Position.X, this.Position.Y + this.VelocityDown);
            }

            this.VelocityUp = this.SpeedPoints;
            this.VelocityLeft = this.SpeedPoints;
            this.VelocityDown = this.SpeedPoints;
            this.VelocityRight = this.SpeedPoints;
        }

        protected void UpdateBoundsLeft()
        {
            this.Bounds = new BoundingBox(new Vector3(this.Position.X + this.Width, this.Position.Y + 64, 0), new Vector3(this.Position.X + (2 * this.Width), Position.Y + (this.Height + 64), 0));
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X + (this.Width - 10), this.Position.Y + 64, 0F),
                new Vector3(this.Position.X + this.Width + this.BaseAttackRadius - 10, this.Position.Y + this.BaseAttackRadius + 64, 0F));
        }

        protected void UpdateBoundsRight()
        {
            this.Bounds = new BoundingBox(new Vector3(this.Position.X, this.Position.Y + 64, 0), new Vector3(this.Position.X + this.Width, Position.Y + (this.Height + 64), 0));
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X + 2 * this.Width, this.Position.Y + 64, 0F),
                new Vector3(this.Position.X + 2 * this.Width + this.BaseAttackRadius, this.Position.Y + this.BaseAttackRadius + 64, 0F));
        }
    }
}
