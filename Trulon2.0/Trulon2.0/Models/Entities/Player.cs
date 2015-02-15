using Microsoft.Xna.Framework.Input;
using Trulon.Config;

namespace Trulon.Models.Entities
{
    using System.Collections.Generic;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public abstract class Player : Entity
    {
        private KeyboardState currentKeyboardState;

        protected Player(
            EntityEquipment playerEquipment,
            string name,
            Texture2D image,
            Rectangle bounds,
            Vector2 position,
            int attackPoints,
            int defencePoints,
            int speedPoints,
            int healthPoints,
            int level,
            List<Item> inventory,
            bool isAlive,
            int experience,
            int coins,
            int skillPoints,
            int attackSkill,
            int defenceSkill,
            int speedSkill,
            int healthSkill)
            : base(name, image, bounds, position, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory, isAlive)
        {
            this.PlayerEquipment = playerEquipment;
            this.Experience = experience;
            this.Coins = coins;
            this.SkillPoints = skillPoints;
            this.AttackSkill = attackSkill;
            this.DefenseSkill = defenceSkill;
            this.SpeedSkill = speedSkill;
            this.HealthSkill = healthSkill;
            
        }
        public EntityEquipment PlayerEquipment { get; set; }
        public int Experience { get; set; }
        public int Coins { get; set; }
        public int SkillPoints { get; set; }
        public int AttackSkill { get; set; }
        public int DefenseSkill { get; set; }
        public int SpeedSkill { get; set; }
        public int HealthSkill { get; set; }

        public override int AttackPoints
        {
            get
            {
                return base.AttackPoints + this.EquipmentBuffs["attack"] + this.AttackSkill;
            }
        }

        public override int DefensePoints
        {
            get
            {
                return base.DefensePoints + this.EquipmentBuffs["defense"] + this.DefenseSkill;
            }
        }

        public override int SpeedPoints
        {
            get
            {
                return base.SpeedPoints+this.EquipmentBuffs["speed"]+this.SpeedSkill;
            }
        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints + this.HealthSkill;
            }
        }
        
        private Dictionary<string, int> EquipmentBuffs
        {
            get
            {
                Dictionary<string, int> buffs = new Dictionary<string, int>();
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
            //Make sure that player doesn't go out of bounds
            this.Position = new Vector2(MathHelper.Clamp(this.Position.X, 0, Config.Config.ScreenWidth - this.Image.Width),
                                            MathHelper.Clamp(this.Position.Y, 0, Config.Config.ScreenHeight - this.Image.Height));
        }

        protected  IList<Entity> GetEnemiesInRange(IList<Entity> entities)
        {
            List<Entity> enemiesInRange = new List<Entity>();
            foreach (var entity in entities)
            {
                if(true) //TODO Add algorithm for checking if entity is in range and if it is enemy
                {
                    enemiesInRange.Add(entity);
                }
            }
            return enemiesInRange;
        }

        protected  Entity GetNPCInRange(IList<Entity> entities)
        {
            List<Entity> entitiesInRange = new List<Entity>();
            foreach (var entity in entities)
            {
                if (true) //TODO Add algorithm for checking if entity is in range and if it is enemy
                {
                    return entity;
                }
            }
            return null;
        }

        protected override void Interact()
        {
            //Entity npc = this.GetNPCInRange();
            //if(npc != null)
            //{
            //    //do some stuff with the npc
            //}
        }

        protected  void Attack()
        {
            //this.GetEntitiesInRange
        }

        protected abstract void AddExperience();

        protected abstract void AddCoins();

        protected abstract void Buy();

        protected abstract void AddSkillPoints();

        protected abstract void UseEquipment();

        protected abstract void DrinkPotion();

    }
}
