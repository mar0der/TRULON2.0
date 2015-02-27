namespace Trulon.CoreLogics
{
    #region Using Statements
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using global::Trulon.Config;
    using global::Trulon.Enums;
    using global::Trulon.GUI;
    using global::Trulon.Models;
    using global::Trulon.Models.Entities;
    using global::Trulon.Models.Entities.NPCs;
    using global::Trulon.Models.Entities.NPCs.Allies;
    using global::Trulon.Models.Entities.NPCs.Enemies;
    using global::Trulon.Models.Entities.Players;
    using global::Trulon.Models.Items.Equipments;
    using global::Trulon.Models.Items.Potions;
    #endregion

    public class Engine : Game
    {
        public readonly Item[] AllEquipments = new Item[5];
        public readonly Item[] AllPotions = new Item[4];
        public readonly Dictionary<EquipmentSlots, Texture2D> AllEmptyEquipmentSlots = new Dictionary<EquipmentSlots, Texture2D>();

        // Loading Entites
        public Player Player;
        public Vendor Vendor;
        public SpriteFont Font;

        public Texture2D HealthBar;

        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;

        protected KeyboardState currentKeyboardState;
        protected KeyboardState previousKeyboardState;

        private static readonly Random Rand = new Random();

        private readonly Texture2D[] backgroundTextures = new Texture2D[Config.NumberOfLevels];

        private readonly List<Enemy>[] enemies = new List<Enemy>[Config.NumberOfLevels];
        private readonly Map[] maps = new Map[Config.NumberOfLevels];

        private GameGUI gui;

        private int currentMap = 0;
        private int countDown;
        private int indexFrame;
        private bool isMoving;
        private bool isAttacking;
        private Texture2D[] animationsRight;
        private Texture2D[] animationsLeft;
        private Texture2D[] animationsRightAttack;
        private Texture2D[] animationsLeftAttack;

        public Engine()
        {
            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Resources";
            this.YouWon = false;
        }

        public bool ShopOpened { get; set; }

        public bool YouWon { get; set; }

        #region Initialize Summary
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        #endregion
        protected override void Initialize()
        {
            // Sets screen size
            this.graphics.PreferredBackBufferWidth = Config.ScreenWidth;
            this.graphics.PreferredBackBufferHeight = Config.ScreenHeight;
            this.graphics.ApplyChanges();
            this.IsMouseVisible = true;

            this.currentMap = 0;

            for (var i = 0; i < Config.NumberOfLevels; i++)
            {
                this.maps[i] = new Map(i, this.backgroundTextures[i]);
            }

            // Setting entities on the scene
            this.Player = new Barbarian((int)this.maps[this.currentMap].PlayerEntryPoint.X, (int)this.maps[this.currentMap].PlayerEntryPoint.Y);
            this.Vendor = new Vendor((int)Config.VendorPosition.X, (int)Config.VendorPosition.Y);

            // Home
            this.enemies[0] = new List<Enemy>();

            // Goblin
            this.enemies[1] = new List<Enemy>
                                  {
                                      new Goblin(400, 400),
                                      new Goblin(500, 400),
                                      new Goblin(600, 400),
                                      new Goblin(700, 400),
                                      new Goblin(800, 400)
                                  };
            
            // Robo
            this.enemies[2] = new List<Enemy>
                                  {
                                      new Robo(400, 400),
                                      new Robo(500, 400),
                                      new Robo(600, 400),
                                      new Robo(700, 400),
                                      new Robo(800, 400)
                                  };
            
            // Ogre
            this.enemies[3] = new List<Enemy>
                                  {
                                      new Ogre(400, 400),
                                      new Ogre(500, 400),
                                      new Ogre(600, 400),
                                      new Ogre(700, 400),
                                      new Ogre(800, 400)
                                  };
            
            // Boss
            this.enemies[4] = new List<Enemy> { new Boss(400, 400) };

            // Items load
            this.AllEquipments[0] = new Boots();
            this.AllEquipments[1] = new Helmet();
            this.AllEquipments[2] = new Shield();
            this.AllEquipments[3] = new Sword();
            this.AllEquipments[4] = new Vest();
            this.AllPotions[0] = new DamagePotion();
            this.AllPotions[1] = new DefensePotion();
            this.AllPotions[2] = new HealthPotion();
            this.AllPotions[3] = new SpeedPotion();

            // GUI
            this.gui = new GameGUI(this);

            base.Initialize();
        }

        #region LoadContent Summary
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        #endregion
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load healthbar image
            this.HealthBar = Content.Load<Texture2D>(Assets.HealthBar);

            // Load Font
            this.Font = Content.Load<SpriteFont>("font");

            // Load map image
            for (var i = 0; i < Config.NumberOfLevels; i++)
            {
                this.backgroundTextures[i] = this.Content.Load<Texture2D>(Assets.Maps[i]);
                this.maps[i].Image = this.backgroundTextures[i];
            }

            // Load the player resources
            this.Player.Initialize(Content.Load<Texture2D>(Assets.BarbarianImages[0]), this.Player.Position);

            this.animationsRight = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[0]),
                Content.Load<Texture2D>(Assets.BarbarianImages[1]),
                Content.Load<Texture2D>(Assets.BarbarianImages[2]),
                Content.Load<Texture2D>(Assets.BarbarianImages[3])
            };

            this.animationsLeft = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[4]),
                Content.Load<Texture2D>(Assets.BarbarianImages[5]),
                Content.Load<Texture2D>(Assets.BarbarianImages[6]),
                Content.Load<Texture2D>(Assets.BarbarianImages[7])
            };

            this.animationsRightAttack = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[8]),
                Content.Load<Texture2D>(Assets.BarbarianImages[9]),
                Content.Load<Texture2D>(Assets.BarbarianImages[10]),
                Content.Load<Texture2D>(Assets.BarbarianImages[11]),
                Content.Load<Texture2D>(Assets.BarbarianImages[0])
            };

            this.animationsLeftAttack = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[12]),
                Content.Load<Texture2D>(Assets.BarbarianImages[13]),
                Content.Load<Texture2D>(Assets.BarbarianImages[14]),
                Content.Load<Texture2D>(Assets.BarbarianImages[15]),
                Content.Load<Texture2D>(Assets.BarbarianImages[4])
            };

            // Load the vendor resources
            this.Vendor.Initialize(Content.Load<Texture2D>(Assets.Vendor[0]), this.Vendor.Position);

            foreach (List<Enemy> levelEnemies in this.enemies)
            {
                foreach (var enemy in levelEnemies)
                {
                    if (enemy is Goblin)
                    {
                        enemy.Initialize(Content.Load<Texture2D>(Assets.GoblinImages[4]), enemy.Position);
                    }
                    else if (enemy is Ogre)
                    {
                        enemy.Initialize(Content.Load<Texture2D>(Assets.OgreImages[4]), enemy.Position);
                    }
                    else if (enemy is Robo)
                    {
                        enemy.Initialize(Content.Load<Texture2D>(Assets.RoboImages[4]), enemy.Position);
                    }
                    else
                    {
                        enemy.Initialize(Content.Load<Texture2D>(Assets.BossImages[4]), enemy.Position);
                    }
                }
            }

            // Load all available items
            this.AllEquipments[0].Initialize(Content.Load<Texture2D>(Assets.Boots), new Vector2(-100, -100));
            this.AllEquipments[1].Initialize(Content.Load<Texture2D>(Assets.Helmet), new Vector2(-100, -100));
            this.AllEquipments[2].Initialize(Content.Load<Texture2D>(Assets.Shield), new Vector2(-100, -100));
            this.AllEquipments[3].Initialize(Content.Load<Texture2D>(Assets.Sword), new Vector2(-100, -100));
            this.AllEquipments[4].Initialize(Content.Load<Texture2D>(Assets.Vest), new Vector2(-100, -100));
            this.AllPotions[0].Initialize(Content.Load<Texture2D>(Assets.DamagePotion), new Vector2(-100, -100));
            this.AllPotions[1].Initialize(Content.Load<Texture2D>(Assets.DefensePotion), new Vector2(-100, -100));
            this.AllPotions[2].Initialize(Content.Load<Texture2D>(Assets.HealthPotion), new Vector2(-100, -100));
            this.AllPotions[3].Initialize(Content.Load<Texture2D>(Assets.SpeedPotion), new Vector2(-100, -100));

            // Add everything into the vendors inventory;
            this.AllEquipments.CopyTo(this.Vendor.Inventory, 0);
            this.AllPotions.CopyTo(this.Vendor.Inventory, this.AllEquipments.Length);

            // Load all availabe emtpy equipment slots images
            this.AllEmptyEquipmentSlots[EquipmentSlots.Head] = Content.Load<Texture2D>(Assets.EmptyHead);
            this.AllEmptyEquipmentSlots[EquipmentSlots.LeftHand] = Content.Load<Texture2D>(Assets.EmptyLeftHand);
            this.AllEmptyEquipmentSlots[EquipmentSlots.RightHand] = Content.Load<Texture2D>(Assets.EmptyRightHand);
            this.AllEmptyEquipmentSlots[EquipmentSlots.Body] = Content.Load<Texture2D>(Assets.EmptyBody);
            this.AllEmptyEquipmentSlots[EquipmentSlots.Feet] = Content.Load<Texture2D>(Assets.EmptyFeet);
        }

        #region UnloadContent Summary
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        #endregion
        protected override void UnloadContent()
        {
            Content.Unload();
            this.Exit();
        }

        #region GameUpdate
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        #endregion
        protected override void Update(GameTime gameTime)
        {
            this.Player.Update();
            
            this.Vendor.Update();

            // Because we`d like to use this logic only for the obsticles with numbers between 2 and n-1.
            // 1 and n are reserver for entry and exit points of the level
            for (var i = 2; i < this.maps[this.currentMap].Obsticles.Length; i++)
            {
                if (this.Player.Intersects(this.maps[this.currentMap].Obsticles[i].ObsticleBox))
                {
                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Up)
                    {
                        this.Player.VelocityUp = 0;
                    }

                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Down)
                    {
                        this.Player.VelocityDown = 0;
                    }

                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Left)
                    {
                        this.Player.VelocityLeft = 0;
                    }

                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Right)
                    {
                        this.Player.VelocityRight = 0;
                    }
                }
            }

            // Level Change
            // If the player can change the level if he colides with one of the entry/exit points
            // For entry point we use the first obsticle
            if (this.Player.AttackBounds.Intersects(this.maps[this.currentMap].Obsticles[0].ObsticleBox) && this.currentMap > 0)
            {
                this.currentMap--;
                this.Player.ReSpawn(this.maps[this.currentMap].PlayerExitPoint);
            }

            // For exit point we use the last obsticle
            if (this.Player.AttackBounds.Intersects(this.maps[this.currentMap].Obsticles[1].ObsticleBox)
                && this.currentMap < 4)
            {
                this.currentMap++;
                this.Player.ReSpawn(this.maps[this.currentMap].PlayerEntryPoint);
            }

            // Recall
            if (this.currentKeyboardState.IsKeyDown(Keys.M) && this.currentMap > 0)
            {
                this.currentMap = 0;
                this.Player.ReSpawn(this.maps[0].PlayerEntryPoint);
            }

            // Update enemies
            if (this.enemies[this.currentMap].Count > 0)
            {
                foreach (var enemy in this.enemies[this.currentMap])
                {
                    enemy.Update();
                }

                for (var i = 0; i < this.enemies[this.currentMap].Count; i++)
                {
                    if (!this.enemies[this.currentMap][i].IsAlive)
                    {
                        this.Player.AddCoins(this.enemies[this.currentMap][i]);
                        this.Player.AddExperience(this.enemies[this.currentMap][i]);
                        this.Player.AddToInventory(this.LootEnemy(ItemTypes.Equipment));
                        this.Player.AddToInventory(this.LootEnemy(ItemTypes.Potion));
                        this.enemies[this.currentMap].RemoveAt(i);
                        break;
                    }
                }
            }

            // You won. When you kill the boss.
            if (this.enemies[Config.NumberOfLevels - 1].Count == 0)
            {
                this.YouWon = true;
            }

            // Move the vendor
            if (this.currentMap > 0)
            {
                this.Vendor.Position = new Vector2(-100, -100);
            }
            else
            {
                this.Vendor.Position = new Vector2(Config.VendorPosition.X, Config.VendorPosition.Y);
            }

            // Use Potions or Equipment from inventory
            this.Player.UseOrEquipFromInventory(Config.UseItemKeys);

            // Drop item from inventory
            this.Player.DropItemFromInventory(Config.DropItemFromInventoryKeys);

            // Unequip Item 
            this.Player.UnequipItem(Config.UnequipItemKeys);

            // Open the shop
            if (this.currentKeyboardState.IsKeyDown(Keys.Tab) && this.Player.GetAllyInRange(new List<Entity>() { this.Vendor }) != null)
            {
                this.ShopOpened = true;
            }
            else
            {
                if (this.Player.GetAllyInRange(new List<Entity>() { this.Vendor }) == null)
                {
                    this.ShopOpened = false;
                }
            }

            // Buy items from the shop
            Keys[] buyItemKeys = Config.BuyItemKeys;
            if (this.currentKeyboardState.GetPressedKeys().Length > 0
                && this.previousKeyboardState.GetPressedKeys().Length == 0
                && buyItemKeys.Contains(this.currentKeyboardState.GetPressedKeys()[0]) && this.ShopOpened)
            {
                int itemAtIndex = Array.IndexOf(buyItemKeys, this.currentKeyboardState.GetPressedKeys()[0]);
                if (this.Player.Coins >= this.Vendor.Inventory[itemAtIndex].Price)
                {
                    this.Player.AddToInventory(this.Vendor.Inventory[itemAtIndex]);
                    this.Player.Coins -= this.Vendor.Inventory[itemAtIndex].Price;
                }
            }

            // Check for player is moving
            var enemiesInRange = this.Player.GetEnemiesInRange(this.enemies[this.currentMap]);
            int chanceToBeAttacked = 0;
            if (enemiesInRange.Count > 0)
            {
                if (this.currentKeyboardState.IsKeyDown(Keys.Space) && this.isAttacking == false)
                {
                    this.indexFrame = 0;
                    this.Player.Attack(enemiesInRange);
                }

                foreach (var enemy in enemiesInRange)
                {
                    if (enemy is Goblin)
                    {
                        chanceToBeAttacked = Rand.Next(0, 20);
                    }

                    if (enemy is Ogre)
                    {
                        chanceToBeAttacked = Rand.Next(0, 40);
                    }

                    if (enemy is Robo)
                    {
                        chanceToBeAttacked = Rand.Next(0, 30);
                    }

                    if (enemy is Boss)
                    {
                        chanceToBeAttacked = Rand.Next(0, 45);
                    }

                    if (chanceToBeAttacked == 1)
                    {
                        enemy.Attack(this.Player);
                    }
                }
            }

            this.UpdateInput();

            if (this.isAttacking || this.isMoving)
            {
                this.AnimatePlayer();
            }

            this.gui.Update();
            base.Update(gameTime);
        }

        #region GameDraw Summary
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        #endregion
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            this.spriteBatch.Begin();

            this.spriteBatch.Draw(this.maps[this.currentMap].Image, new Rectangle(0, 0, this.backgroundTextures[0].Width, this.backgroundTextures[0].Height), Color.White);
            this.Vendor.Draw(this.spriteBatch);

            foreach (var enemy in this.enemies[this.currentMap])
            {
                enemy.Draw(this.spriteBatch);
            }

            this.gui.Draw(this.spriteBatch);
            this.Player.Draw(this.spriteBatch);
            
            this.spriteBatch.End();

            base.Draw(gameTime);
        }

        private void AnimatePlayer()
        {
            if (this.countDown == 0)
            {
                // Change direction
                if (this.isAttacking)
                {
                    switch (this.Player.PreviousDirection)
                    {
                        case Direction.Right:
                            this.Player.Image = this.animationsRightAttack[this.indexFrame++];
                            if (this.indexFrame == this.animationsRightAttack.Length)
                            {
                                this.isAttacking = false;
                                this.indexFrame = 0;
                            }

                            break;
                        case Direction.Left:
                            this.Player.Image = this.animationsLeftAttack[this.indexFrame++];
                            if (this.indexFrame == this.animationsLeftAttack.Length)
                            {
                                this.isAttacking = false;
                                this.indexFrame = 0;
                            }

                            break;
                    }
                }
                else if (this.Player.PreviousDirection == Direction.Right)
                {
                    if (this.indexFrame >= this.animationsRight.Length)
                    {
                        this.indexFrame = 0;
                    }
                    else
                    {
                        this.Player.Image = this.animationsRight[this.indexFrame++];
                    }
                }
                else
                {
                    if (this.indexFrame >= this.animationsLeft.Length)
                    {
                        this.indexFrame = 0;
                    }
                    else
                    {
                        this.Player.Image = this.animationsLeft[this.indexFrame++];
                    }
                }

                this.countDown = 10;
            }

            this.countDown--;
        }

        private void UpdateInput()
        {
            var newState = Keyboard.GetState();

            // Is the SPACE key down?
            if (newState.IsKeyDown(Keys.Up) ||
                newState.IsKeyDown(Keys.Down) ||
                newState.IsKeyDown(Keys.Right) ||
                newState.IsKeyDown(Keys.Left))
            {
                // If not down last update, key has just been pressed.
                if (!this.previousKeyboardState.IsKeyDown(Keys.Up) ||
                    !this.previousKeyboardState.IsKeyDown(Keys.Down) ||
                    !this.previousKeyboardState.IsKeyDown(Keys.Right) ||
                    !this.previousKeyboardState.IsKeyDown(Keys.Left))
                {
                    this.isMoving = true;
                }
            }
            else if (this.previousKeyboardState.IsKeyDown(Keys.Up) ||
                     this.previousKeyboardState.IsKeyDown(Keys.Down) ||
                     this.previousKeyboardState.IsKeyDown(Keys.Right) ||
                     this.previousKeyboardState.IsKeyDown(Keys.Left))
            {
                // Key was down last update, but not down now, so it has just been released.
                this.isMoving = false;
            }

            if (newState.IsKeyDown(Keys.Space))
            {
                this.isAttacking = true;
            }

            // Update saved state.
            this.previousKeyboardState = newState;
        }

        private Item LootEnemy(ItemTypes type)
        {
            int chance = Rand.Next(0, 3);
            if (chance == 0)
            {
                return type == ItemTypes.Potion ? ItemGenerator.GetPotionItem(this.AllPotions) : ItemGenerator.GetEquipmentItem(this.AllEquipments);
            }

            return null;
        }
    }
}
