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
        private string gameState = "startGame";
        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;

        public SpriteFont font;
        private GameGUI gui;

        private static Random rand = new Random();

        private Texture2D[] backgroundTextures = new Texture2D[Config.NumberOfLevels];
        //Loading Entites
        public Player player;
        public Vendor vendor;
        private List<Enemy>[] enemies = new List<Enemy>[Config.NumberOfLevels];
        private Map[] maps = new Map[Config.NumberOfLevels];
        private int currentMap = 0;

        protected KeyboardState currentKeyboardState;
        protected KeyboardState previousKeyboardState;

        private int countDown;
        private int indexFrame;
        private bool isMoving;
        private bool isAttacking;
        private Texture2D[] AnimationsRight;
        private Texture2D[] AnimationsLeft;
        private Texture2D[] AnimationsRightAttack;
        private Texture2D[] AnimationsLeftAttack;

        public Texture2D healthBar;

        public readonly Item[] AllEquipments = new Item[5];
        public readonly Item[] AllPotions = new Item[4];
        public readonly Dictionary<EquipmentSlots, Texture2D> AllEmptyEquipmentSlots =
            new Dictionary<EquipmentSlots, Texture2D>();

        //testing bounding box
        private Texture2D boundsTest;
        private Texture2D boundsTest2;

        public bool ShopOpened { get; set; }

        public bool YouWon { get; set; }

        public Engine()
        {
            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Resources";
            this.YouWon = false;
        }

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
            //Sets screen size
            this.graphics.PreferredBackBufferWidth = Config.ScreenWidth;
            this.graphics.PreferredBackBufferHeight = Config.ScreenHeight;
            this.graphics.ApplyChanges();
            this.IsMouseVisible = true;

            for (int i = 0; i < Config.NumberOfLevels; i++)
            {
                this.maps[i] = new Map(i, this.backgroundTextures[i]);
            }

            //setting entites on the scene
            this.player = new Barbarian((int)this.maps[this.currentMap].PlayerEntryPloint.X, (int)this.maps[this.currentMap].PlayerEntryPloint.Y);
            this.vendor = new Vendor(650, 300);
            //home
            this.enemies[0] = new List<Enemy>();
            //Goblin
            this.enemies[1] = new List<Enemy>();
            this.enemies[1].Add(new Goblin(400, 400));
            this.enemies[1].Add(new Goblin(500, 400));
            this.enemies[1].Add(new Goblin(600, 400));
            this.enemies[1].Add(new Goblin(700, 400));
            this.enemies[1].Add(new Goblin(800, 400));
            //Robo
            this.enemies[2] = new List<Enemy>();
            this.enemies[2].Add(new Robo(400, 400));
            this.enemies[2].Add(new Robo(500, 400));
            this.enemies[2].Add(new Robo(600, 400));
            this.enemies[2].Add(new Robo(700, 400));
            this.enemies[2].Add(new Robo(800, 400));
            //Ogre
            this.enemies[3] = new List<Enemy>();
            this.enemies[3].Add(new Ogre(400, 400));
            this.enemies[3].Add(new Ogre(500, 400));
            this.enemies[3].Add(new Ogre(600, 400));
            this.enemies[3].Add(new Ogre(700, 400));
            this.enemies[3].Add(new Ogre(800, 400));
            //Boss
            this.enemies[4] = new List<Enemy>();
            this.enemies[4].Add(new Boss(400, 400));

            //items load
            this.AllEquipments[0] = new Boots();
            this.AllEquipments[1] = new Helmet();
            this.AllEquipments[2] = new Shield();
            this.AllEquipments[3] = new Sword();
            this.AllEquipments[4] = new Vest();
            this.AllPotions[0] = new DamagePotion();
            this.AllPotions[1] = new DefensePotion();
            this.AllPotions[2] = new HealthPotion();
            this.AllPotions[3] = new SpeedPotion();

            //this is for testing only. remove it when done
            //this.player.PlayerEquipment.CurrentEquipment.Add(EquipmentSlots.RightHand, AllEquipments[3] as Equipment);

            //GUI
            this.gui = new GameGUI(this);
            this.gui.Initialize();

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

            //testing bounding box
            int boundWidth = (int)(this.player.Bounds.Max.X - this.player.Bounds.Min.X);
            int boundHeight = (int)(this.player.Bounds.Max.Y - this.player.Bounds.Min.Y);
            boundsTest = new Texture2D(this.graphics.GraphicsDevice, boundWidth, boundHeight);
            Color[] data = new Color[boundWidth * boundHeight];


            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Color.Chocolate;
            }
            boundsTest.SetData(data);

            int boundWidth2 = (int)(this.player.AttackBounds.Max.X - this.player.AttackBounds.Min.X);
            int boundHeight2 = (int)(this.player.AttackBounds.Max.Y - this.player.AttackBounds.Min.Y);
            boundsTest2 = new Texture2D(graphics.GraphicsDevice, boundWidth2, boundHeight2);
            Color[] data2 = new Color[boundWidth2 * boundHeight2];


            for (int i = 0; i < data2.Length; ++i)
            {
                data2[i] = Color.Red;
            }
            boundsTest2.SetData(data2);


            //Load healthbar image
            this.healthBar = Content.Load<Texture2D>(Assets.HealthBar);

            //Load Font
            this.font = Content.Load<SpriteFont>("font");

            //Load map image
            for (int i = 0; i < Config.NumberOfLevels; i++)
            {
                this.backgroundTextures[i] = this.Content.Load<Texture2D>(Assets.Maps[i]);
                this.maps[i].Image = this.backgroundTextures[i];
            }

            //Load the player resources
            this.player.Initialize(Content.Load<Texture2D>(Assets.BarbarianImages[0]), this.player.Position);

            this.AnimationsRight = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[0]),
                Content.Load<Texture2D>(Assets.BarbarianImages[1]),
                Content.Load<Texture2D>(Assets.BarbarianImages[2]),
                Content.Load<Texture2D>(Assets.BarbarianImages[3])
            };

            this.AnimationsLeft = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[4]),
                Content.Load<Texture2D>(Assets.BarbarianImages[5]),
                Content.Load<Texture2D>(Assets.BarbarianImages[6]),
                Content.Load<Texture2D>(Assets.BarbarianImages[7])
            };

            this.AnimationsRightAttack = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[8]),
                Content.Load<Texture2D>(Assets.BarbarianImages[9]),
                Content.Load<Texture2D>(Assets.BarbarianImages[10]),
                Content.Load<Texture2D>(Assets.BarbarianImages[11]),
                Content.Load<Texture2D>(Assets.BarbarianImages[0])
            };

            this.AnimationsLeftAttack = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[12]),
                Content.Load<Texture2D>(Assets.BarbarianImages[13]),
                Content.Load<Texture2D>(Assets.BarbarianImages[14]),
                Content.Load<Texture2D>(Assets.BarbarianImages[15]),
                Content.Load<Texture2D>(Assets.BarbarianImages[4])
            };

            //Load the vendor resources
            this.vendor.Initialize(Content.Load<Texture2D>(Assets.Vendor[0]), this.vendor.Position);

            foreach (List<Enemy> levelEnemies in enemies)
            {
                foreach (var enemy in levelEnemies)
                {
                    if (enemy is Goblin)
                    {
                        enemy.Initialize(Content.Load<Texture2D>(Assets.GoblinImages[0]), enemy.Position);
                    }
                    else if (enemy is Ogre)
                    {
                        enemy.Initialize(Content.Load<Texture2D>(Assets.OgreImages[0]), enemy.Position);
                    }
                    else
                    {
                        enemy.Initialize(Content.Load<Texture2D>(Assets.RoboImages[0]), enemy.Position);
                    }
                }
            }

            //Load all available items
            this.AllEquipments[0].Initialize(Content.Load<Texture2D>(Assets.Boots), new Vector2(-100, -100));
            this.AllEquipments[1].Initialize(Content.Load<Texture2D>(Assets.Helmet), new Vector2(-100, -100));
            this.AllEquipments[2].Initialize(Content.Load<Texture2D>(Assets.Shield), new Vector2(-100, -100));
            this.AllEquipments[3].Initialize(Content.Load<Texture2D>(Assets.Sword), new Vector2(-100, -100));
            this.AllEquipments[4].Initialize(Content.Load<Texture2D>(Assets.Vest), new Vector2(-100, -100));
            this.AllPotions[0].Initialize(Content.Load<Texture2D>(Assets.DamagePotion), new Vector2(-100, -100));
            this.AllPotions[1].Initialize(Content.Load<Texture2D>(Assets.DefensePotion), new Vector2(-100, -100));
            this.AllPotions[2].Initialize(Content.Load<Texture2D>(Assets.HealthPotion), new Vector2(-100, -100));
            this.AllPotions[3].Initialize(Content.Load<Texture2D>(Assets.SpeedPotion), new Vector2(-100, -100));

            //Add every thing into the vendors inventory;
            this.AllEquipments.CopyTo(this.vendor.Inventory, 0);
            this.AllPotions.CopyTo(this.vendor.Inventory, this.AllEquipments.Length);

            //Load all availabe emtpy euqipment slots images
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
            //Update player
            this.player.Update();

            //because we`d like to use this logic only for the obsticles with numbers between 2 and n-1.
            //1 and n are reserver for entry and exit points of the level
            for (var i = 2; i < this.maps[currentMap].Obsticles.Length; i++)
            {
                if (this.player.Intersects(this.maps[this.currentMap].Obsticles[i].ObsticleBox))
                {
                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Up)
                    {
                        this.player.VelocityUp = 0;
                    }
                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Down)
                    {
                        this.player.VelocityDown = 0;
                    }
                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Left)
                    {
                        this.player.VelocityLeft = 0;
                    }
                    if (this.maps[this.currentMap].Obsticles[i].RestrictedDirection == Direction.Right)
                    {
                        this.player.VelocityRight = 0;
                    }
                }
            }

            //Level Change
            //If the player can change the level if he colides with one of the entry/exit points
            //for entry point we use the first obsticle
            if (this.player.AttackBounds.Intersects(this.maps[this.currentMap].Obsticles[0].ObsticleBox) && this.currentMap > 0)
            {
                this.currentMap--;
                this.player.ReSpawn(this.maps[this.currentMap].PlayerExitPloint);
            }
            //for exit point we use the last obsticle
            if (this.player.AttackBounds.Intersects(this.maps[this.currentMap].Obsticles[1].ObsticleBox)
                && this.currentMap < 4)
            {
                this.currentMap++;
                this.player.ReSpawn(this.maps[this.currentMap].PlayerEntryPloint);
            }

            //Recall
            if (this.currentKeyboardState.IsKeyDown(Keys.M) && this.currentMap > 0)
            {
                this.currentMap = 0;
                this.player.ReSpawn(this.maps[0].PlayerEntryPloint);
            }

            //update enemies
            if (enemies[currentMap].Count > 0)
            {
                foreach (var enemy in this.enemies[currentMap])
                {
                    enemy.Update();
                }

                for (var i = 0; i < this.enemies[this.currentMap].Count; i++)
                {
                    if (!this.enemies[this.currentMap][i].IsAlive)
                    {
                        this.player.AddCoins(this.enemies[currentMap][i]);
                        this.player.AddExperience(this.enemies[this.currentMap][i]);
                        this.player.AddToInventory(this.LootEnemy("equipment"));
                        this.player.AddToInventory(this.LootEnemy("potion"));
                        this.enemies[this.currentMap].RemoveAt(i);
                        break;
                    }
                }
            }
            //You won. wen you kill the boss
            if (this.enemies[Config.NumberOfLevels-1].Count == 0)
            {
                this.YouWon = true;
            }

            //Use Potions or Equipment from inventory
            this.player.UseOrEquipFromInventory(Config.UseItemKeys);

            //Drop item from inventory
            this.player.DropItemFromInventory(Config.DropItemFromInventoryKeys);

            //Unequip Item 
            this.player.UnequipItem(Config.UnequipItemKeys);

            //Open the shop
            if (this.currentKeyboardState.IsKeyDown(Keys.Tab) && this.player.GetAllyInRange(new List<Entity>() { this.vendor }) != null)
            {
                this.ShopOpened = true;
            }
            else
            {
                if (this.player.GetAllyInRange(new List<Entity>() { this.vendor }) == null)
                {
                    this.ShopOpened = false;
                }
            }

            //Buy shits from the shop
            Keys[] buyItemKeys = Config.BuyItemKeys;
            if (this.currentKeyboardState.GetPressedKeys().Length > 0
                && this.previousKeyboardState.GetPressedKeys().Length == 0
                && buyItemKeys.Contains(this.currentKeyboardState.GetPressedKeys()[0])
                && this.ShopOpened)
            {
                int itemAtIndex = Array.IndexOf(buyItemKeys, this.currentKeyboardState.GetPressedKeys()[0]);
                if (this.player.Coins >= this.vendor.Inventory[itemAtIndex].Price)
                {
                    this.player.AddToInventory(this.vendor.Inventory[itemAtIndex]);
                    this.player.Coins -= this.vendor.Inventory[itemAtIndex].Price;
                }
            }

            //Check for player is moving
            var enemiesInRange = this.player.GetEnemiesInRange(this.enemies[this.currentMap]);
            int chanceToBeAttacked = 0;
            if (enemiesInRange.Count > 0)
            {
                if (this.currentKeyboardState.IsKeyDown(Keys.Space) && this.isAttacking == false)
                {
                    this.indexFrame = 0;
                    this.player.Attack(enemiesInRange);
                }
                foreach (var enemy in enemiesInRange)
                {
                    if (enemy is Goblin)
                    {
                        chanceToBeAttacked = rand.Next(0, 20);
                    }
                    if (enemy is Ogre)
                    {
                        chanceToBeAttacked = rand.Next(0, 40);
                    }
                    if (enemy is Robo)
                    {
                        chanceToBeAttacked = rand.Next(0, 30);
                    }
                    if (enemy is Boss)
                    {
                        chanceToBeAttacked = rand.Next(0, 45);
                    }
                    if (chanceToBeAttacked == 1)
                    {
                        enemy.Attack(this.player);
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

        private void UpdateInput()
        {
            KeyboardState newState = Keyboard.GetState();

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
                // Key was down last update, but not down now, so
                // it has just been released.

                this.isMoving = false;
            }

            if (newState.IsKeyDown(Keys.Space))
            {
                this.isAttacking = true;
            }

            // Update saved state.
            this.previousKeyboardState = newState;
        }

        #region GameDraw Summary
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        #endregion
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            this.spriteBatch.Begin();

            this.spriteBatch.Draw(this.maps[this.currentMap].Image, new Rectangle(0, 0, this.backgroundTextures[0].Width, this.backgroundTextures[0].Height), Color.White);


            this.vendor.Draw(this.spriteBatch);


            foreach (var enemy in this.enemies[this.currentMap])
            {
                enemy.Draw(this.spriteBatch);
            }

            this.gui.Draw(this.spriteBatch);

            this.player.Draw(this.spriteBatch);

            Vector2 minBounds = new Vector2(this.player.Bounds.Min.X + 54, this.player.Bounds.Min.Y + 24);
            spriteBatch.Draw(boundsTest, minBounds, Color.White);

            Vector2 minBounds2 = new Vector2(this.player.AttackBounds.Min.X, this.player.AttackBounds.Min.Y);
            spriteBatch.Draw(boundsTest2, minBounds2, Color.White);

            this.spriteBatch.End();
            base.Draw(gameTime);
        }

        private void AnimatePlayer()
        {
            if (this.countDown == 0)
            {
                //change direction
                if (this.isAttacking)
                {
                    if (this.player.PreviousDirection == "right")
                    {
                        this.player.Image = this.AnimationsRightAttack[this.indexFrame++];
                        if (this.indexFrame == this.AnimationsRightAttack.Length)
                        {
                            this.isAttacking = false;
                            this.indexFrame = 0;
                        }

                    }
                    else if (this.player.PreviousDirection == "left")
                    {
                        this.player.Image = this.AnimationsLeftAttack[this.indexFrame++];
                        if (this.indexFrame == this.AnimationsLeftAttack.Length)
                        {
                            this.isAttacking = false;
                            this.indexFrame = 0;
                        }
                    }
                }
                else if (this.player.PreviousDirection == "right")
                {
                    if (this.indexFrame >= this.AnimationsRight.Length)
                    {
                        this.indexFrame = 0;
                    }
                    else
                    {
                        this.player.Image = this.AnimationsRight[this.indexFrame++];
                    }

                }
                else
                {
                    if (this.indexFrame >= this.AnimationsLeft.Length)
                    {
                        this.indexFrame = 0;
                    }
                    else
                    {
                        this.player.Image = this.AnimationsLeft[this.indexFrame++];
                    }

                }

                this.countDown = 10;

            }

            this.countDown--;
        }

        private Item LootEnemy(string type)
        {
            int chance = rand.Next(0, 1);
            if (chance == 0)
            {
                if (type == "potion")
                {
                    return ItemGenerator.GetPotionItem(this.AllPotions);
                }
                return ItemGenerator.GetEquipmentItem(this.AllEquipments);
            }
            return null;
        }
    }
}
