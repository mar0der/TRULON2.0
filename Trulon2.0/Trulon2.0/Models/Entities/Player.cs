using Microsoft.Xna.Framework.Graphics;
using Trulon.Models.Items;

namespace Trulon.Models.Entities
{
    using System;
    using System.Collections.Generic;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;

    using global::Trulon.Models.Entities.NPCs;

    public abstract class Player : Entity
    {
        private KeyboardState currentKeyboardState;

        public EntityEquipment PlayerEquipment { get; set; }

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
                return this.BaseAttack + this.EquipmentBuffs["attack"] + this.AttackSkill;
            }
        }

        public int DefensePoints
        {
            get
            {
                return this.BaseDefense + this.EquipmentBuffs["defense"] + this.DefenseSkill;
            }
        }

        public int SpeedPoints
        {
            get
            {
                return this.BaseSpeed + this.EquipmentBuffs["speed"] + this.SpeedSkill;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.BaseHealth + this.HealthSkill;
            }
        }
        
        private Dictionary<string, int> EquipmentBuffs
        {
            get
            {
                var buffs = new Dictionary<string, int>();
                int attackBuff = 0, defenseBuff = 0, speedBuff = 0;
                foreach (var item in this.PlayerEquipment.CurrentEquipment)
                {
                    attackBuff += item.Value.AttackPointsBuff;
                    defenseBuff += item.Value.DefensePointsBuff;
                    speedBuff += item.Value.SpeedPointsBuff;
                }
                buffs.Add("attack", attackBuff);
                buffs.Add("defense", defenseBuff);
                buffs.Add("speed", speedBuff);
                return buffs;
            }
        }

        public override void Update()
        {
            currentKeyboardState = Keyboard.GetState();
            //Keyboard input
            this.Move(); 
            //Make sure that player doesn't go out of bounds
            this.Position = new Vector2(MathHelper.Clamp(this.Position.X, 0, Config.Config.ScreenWidth - this.Image.Width),
                                            MathHelper.Clamp(this.Position.Y, 0, Config.Config.ScreenHeight - this.Image.Height));

            this.Bounds = new BoundingBox(new Vector3(this.Position.X, this.Position.Y, 0), new Vector3(this.Position.X + this.Width, this.Position.Y + this.Height, 0));
        }

        public IList<Enemy> GetEnemiesInRange(IList<Enemy> enemies)
        {
            var enemiesInRange = new List<Enemy>();

            foreach (var enemy in enemies)
            {
                if(this.Bounds.Intersects(enemy.Bounds))
                {
                    enemiesInRange.Add(enemy);
                }
            }
            return enemiesInRange;
        }

        public Ally GetAllyInRange (IList<Entity> entities)
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
                enemy.BaseHealth -= this.AttackPoints;
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

        protected void AddSkillPoints()
        {
            throw new NotImplementedException("Buy method is not implemented");                
        }

        public void UseEquipment(Equipment equipment)
        {
            if (!this.PlayerEquipment.CurrentEquipment.ContainsKey(equipment.Slot))
            {
                this.PlayerEquipment.CurrentEquipment.Add(equipment.Slot, equipment);
                this.Inventory.Remove(equipment);
            }
            else
            {
                this.Inventory.Add(this.PlayerEquipment.CurrentEquipment[equipment.Slot]);
                this.PlayerEquipment.CurrentEquipment.Add(equipment.Slot, equipment);
                this.Inventory.Remove(equipment);
            }
        }

        protected void DrinkPotion()
        {
            throw new NotImplementedException("Buy method is not implemented");                
        }

        protected override void Move()
        {
            if (currentKeyboardState.IsKeyDown(Keys.Left))
            {
                this.Position = new Vector2(this.Position.X - this.SpeedPoints, this.Position.Y);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Right))
            {
                this.Position = new Vector2(this.Position.X + this.SpeedPoints, this.Position.Y);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Up))
            {
                this.Position = new Vector2(this.Position.X, this.Position.Y - this.SpeedPoints);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Down))
            {
                this.Position = new Vector2(this.Position.X, this.Position.Y + this.SpeedPoints);
            }
        }
    }
}
