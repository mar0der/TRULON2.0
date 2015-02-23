using System.Linq;
using System.Web.UI.WebControls;

namespace Trulon.CoreLogics
{
    #region Using Statements
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using global::Trulon.Config;
    using global::Trulon.Enums;
    using global::Trulon.GUI;
    using global::Trulon.GUI.Menu;
    using global::Trulon.Models;
    using global::Trulon.Models.Entities;
    using global::Trulon.Models.Entities.NPCs;
    using global::Trulon.Models.Entities.NPCs.Allies;
    using global::Trulon.Models.Entities.NPCs.Enemies;
    using global::Trulon.Models.Entities.Players;
    using global::Trulon.Models.Items;
    using global::Trulon.Models.Items.Equipments;
    using global::Trulon.Models.Items.Potions;
    using global::Trulon.Models.Maps;
    #endregion

    public class Engine : Game
    {
        GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Screen currentScreen;
        public SpriteFont font;
        private GameGUI gui;

        private static Random rand = new Random();

        private Texture2D backgroundTexture;
        //Loading Entites
        public Player player;
        public Vendor vendor;
        private IList<Enemy> enemies;
        private Map[] maps = new Map[5];
        private int currentMap = 0;

        private KeyboardState currentKeyboardState;
        private KeyboardState previousKeyboardState;

        private int countDown;
        private int indexFrame;
        private bool isMoving;
        private bool isAttacking;
        private Texture2D[] AnimationsRight;
        private Texture2D[] AnimationsLeft;
        private Texture2D[] AnimationsRightAttack;
        private Texture2D[] AnimationsLeftAttack;

        public readonly Item[] AllEquipments = new Item[5];
        public readonly Item[] AllPotions = new Item[5];
        public readonly Dictionary<EquipmentSlots, Texture2D> AllEmptyEquipmentSlots =
            new Dictionary<EquipmentSlots, Texture2D>();


        public Engine()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Resources";
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
            // TODO: Add your initialization logic here
            IsMouseVisible = true;

            //setting entites on the scene
            this.player = new Barbarian(232, 96);
            this.vendor = new Vendor(650, 300);
            this.enemies = new List<Enemy>()
            {
                new Goblin(200, 50),
                new Goblin(232, 146),
                new Robo(500, 200),
                new Ogre(500, 350),
                new Boss(500, 350)
            };

            maps[0] = new Level1();
            maps[1] = new Level2();
            maps[2] = new Level3();

            //items load

            AllEquipments[0] = new Boots();
            AllEquipments[1] = new Helmet();
            AllEquipments[2] = new Shield();
            AllEquipments[3] = new Sword();
            AllEquipments[4] = new Vest();
            AllPotions[0] = new DamagePotion();
            AllPotions[1] = new DefensePotion();
            AllPotions[2] = new HealthPotion();
            AllPotions[3] = new SpeedPotion();
            AllPotions[4] = new AttackRangePotion();

            //this is for testing only. remove it when done
            this.player.PlayerEquipment.CurrentEquipment.Add(EquipmentSlots.RightHand, AllEquipments[3] as Equipment);

            //GUI
            this.gui = new GameGUI(this);
            gui.Initialize();

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

            //Load Font
            this.font = Content.Load<SpriteFont>("font");

            //Load map image
            this.backgroundTexture = this.Content.Load<Texture2D>("Images/MapImages/TrulonHomeMap");

            //Load the player resources
            this.player.Initialize(Content.Load<Texture2D>(Assets.BarbarianImages[0]), this.player.Position);

            AnimationsRight = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[0]),
                Content.Load<Texture2D>(Assets.BarbarianImages[1]),
                Content.Load<Texture2D>(Assets.BarbarianImages[2]),
                Content.Load<Texture2D>(Assets.BarbarianImages[3])
            };

            AnimationsLeft = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[4]),
                Content.Load<Texture2D>(Assets.BarbarianImages[5]),
                Content.Load<Texture2D>(Assets.BarbarianImages[6]),
                Content.Load<Texture2D>(Assets.BarbarianImages[7])
            };

            AnimationsRightAttack = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[8]),
                Content.Load<Texture2D>(Assets.BarbarianImages[9]),
                Content.Load<Texture2D>(Assets.BarbarianImages[10]),
                Content.Load<Texture2D>(Assets.BarbarianImages[11]),
                Content.Load<Texture2D>(Assets.BarbarianImages[0])
            };

            AnimationsLeftAttack = new[]
            {
                Content.Load<Texture2D>(Assets.BarbarianImages[12]),
                Content.Load<Texture2D>(Assets.BarbarianImages[13]),
                Content.Load<Texture2D>(Assets.BarbarianImages[14]),
                Content.Load<Texture2D>(Assets.BarbarianImages[15]),
                Content.Load<Texture2D>(Assets.BarbarianImages[4])
            };

            //Load the vendor resources
            this.vendor.Initialize(Content.Load<Texture2D>(Assets.Vendor[0]), this.vendor.Position);

            foreach (var enemy in enemies)
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

            //Load all available items
            AllEquipments[0].Initialize(Content.Load<Texture2D>(Assets.Boots), new Vector2(-100, -100));
            AllEquipments[1].Initialize(Content.Load<Texture2D>(Assets.Helmet), new Vector2(-100, -100));
            AllEquipments[2].Initialize(Content.Load<Texture2D>(Assets.Shield), new Vector2(-100, -100));
            AllEquipments[3].Initialize(Content.Load<Texture2D>(Assets.Sword), new Vector2(-100, -100));
            AllEquipments[4].Initialize(Content.Load<Texture2D>(Assets.Vest), new Vector2(-100, -100));
            AllPotions[0].Initialize(Content.Load<Texture2D>(Assets.DamagePotion), new Vector2(-100, -100));
            AllPotions[1].Initialize(Content.Load<Texture2D>(Assets.DefensePotion), new Vector2(-100, -100));
            AllPotions[2].Initialize(Content.Load<Texture2D>(Assets.HealthPotion), new Vector2(-100, -100));
            AllPotions[3].Initialize(Content.Load<Texture2D>(Assets.SpeedPotion), new Vector2(-100, -100));
            AllPotions[4].Initialize(Content.Load<Texture2D>(Assets.AttackRangePotion), new Vector2(-100, -100));

            //Add every thing into the vendors inventory;
            AllEquipments.CopyTo(this.vendor.Inventory, 0);
            AllPotions.CopyTo(this.vendor.Inventory, AllEquipments.Length);

            //Load all availabe emtpy euqipment slots images
            AllEmptyEquipmentSlots[EquipmentSlots.Head] = Content.Load<Texture2D>(Assets.EmptyHead);
            AllEmptyEquipmentSlots[EquipmentSlots.LeftHand] = Content.Load<Texture2D>(Assets.EmptyLeftHand);
            AllEmptyEquipmentSlots[EquipmentSlots.RightHand] = Content.Load<Texture2D>(Assets.EmptyRightHand);
            AllEmptyEquipmentSlots[EquipmentSlots.Body] = Content.Load<Texture2D>(Assets.EmptyBody);
            AllEmptyEquipmentSlots[EquipmentSlots.Feet] = Content.Load<Texture2D>(Assets.EmptyFeet);
        }

        #region UnloadContent Summary
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        #endregion
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Save previous state of the keyboard to determine single key presses
            previousKeyboardState = currentKeyboardState;
            //Read the current state of the keyboard and store it
            currentKeyboardState = Keyboard.GetState();

            //Update player
            this.player.Update(maps[currentMap], enemies);

            //update enemies
            foreach (var enemy in enemies)
            {
                enemy.Update();
            }

            for (var i = 0; i < this.enemies.Count; i++)
            {
                if (!this.enemies[i].IsAlive)
                {
                    this.player.AddCoins(this.enemies[i]);
                    this.player.AddExperience(this.enemies[i]);
                    this.player.AddToInventory(this.LootEnemy("equipment"));
                    this.player.AddToInventory(this.LootEnemy("potion"));
                    this.enemies.RemoveAt(i);
                    break;
                }
            }

            if (this.enemies.Count == 0)
            {
                //TODO
            }

            //Use Potions or Equipment from inventory
            Keys[] useItemKeys = Config.UseItemKeys;

            if (currentKeyboardState.GetPressedKeys().Length > 0 && useItemKeys.Contains(currentKeyboardState.GetPressedKeys()[0]))
            {
                int itemAtIndex = Array.IndexOf(useItemKeys, currentKeyboardState.GetPressedKeys()[0]);

                if (this.player.Inventory.ElementAt(itemAtIndex) is Potion)
                {
                    this.player.DrinkPotion(itemAtIndex);
                }
                else if (this.player.Inventory.ElementAt(itemAtIndex) is Equipment)
                {
                    this.player.UseEquipment(itemAtIndex);
                }
            }

            //Dump item from inventory
            Keys[] dumpItemFromInventory = Config.DumpItemFromInvontoryKeys;

            if (currentKeyboardState.GetPressedKeys().Length > 0 && dumpItemFromInventory.Contains(currentKeyboardState.GetPressedKeys()[0]))
            {
                int itemAtIndex = Array.IndexOf(dumpItemFromInventory, currentKeyboardState.GetPressedKeys()[0]);
                this.player.DumpItem(itemAtIndex);
            }

            //Deequip Item 
            Keys[] DeequipItem = Config.DeequipItemKeys;
            if (currentKeyboardState.GetPressedKeys().Length > 0 && DeequipItem.Contains(currentKeyboardState.GetPressedKeys()[0]))
            {
                var itemAtIndex = Array.IndexOf(DeequipItem, currentKeyboardState.GetPressedKeys()[0]);
                switch (itemAtIndex)
                {
                    case 0:
                        this.player.DeequipItem(EquipmentSlots.Head);
                        break;
                    case 1:
                        this.player.DeequipItem(EquipmentSlots.LeftHand);
                        break;
                    case 2:
                        this.player.DeequipItem(EquipmentSlots.RightHand);
                        break;
                    case 3:
                        this.player.DeequipItem(EquipmentSlots.Body);
                        break;
                    case 4:
                        this.player.DeequipItem(EquipmentSlots.Feet);
                        break;
                }
            }

            //Open the shop
            if (currentKeyboardState.IsKeyDown(Keys.Tab) && this.player.GetAllyInRange(new List<Entity>() { this.vendor }) != null)
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
            if (currentKeyboardState.GetPressedKeys().Length > 0 
                && previousKeyboardState.GetPressedKeys().Length == 0
                && buyItemKeys.Contains(currentKeyboardState.GetPressedKeys()[0]) 
                && this.ShopOpened)
            {
                int itemAtIndex = Array.IndexOf(buyItemKeys, currentKeyboardState.GetPressedKeys()[0]);
                this.player.AddToInventory(this.vendor.Inventory[itemAtIndex]);
            }


            //Check for player is moving
            var enemiesInRange = this.player.GetEnemiesInRange(enemies);
            if (enemiesInRange.Count > 0)
            {
                if (currentKeyboardState.IsKeyDown(Keys.Space) && isAttacking == false)
                {
                    indexFrame = 0;
                    this.player.Attack(enemiesInRange);
                }
            }

            UpdateInput();

            if (isAttacking || isMoving)
            {
                this.AnimatePlayer();
            }

            //Check for going in another world
            if ((int)this.player.Position.X == 200 && (int)this.player.Position.Y == 300)
            {
                throw new Exception("New wolrd;");
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
                if (!previousKeyboardState.IsKeyDown(Keys.Up) ||
                    !previousKeyboardState.IsKeyDown(Keys.Down) ||
                    !previousKeyboardState.IsKeyDown(Keys.Right) ||
                    !previousKeyboardState.IsKeyDown(Keys.Left))
                {
                    isMoving = true;
                }
            }
            else if (previousKeyboardState.IsKeyDown(Keys.Up) ||
                     previousKeyboardState.IsKeyDown(Keys.Down) ||
                     previousKeyboardState.IsKeyDown(Keys.Right) ||
                     previousKeyboardState.IsKeyDown(Keys.Left))
            {
                // Key was down last update, but not down now, so
                // it has just been released.

                isMoving = false;
            }

            if (newState.IsKeyDown(Keys.Space))
            {
                isAttacking = true;
            }

            // Update saved state.
            previousKeyboardState = newState;
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

            this.spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, backgroundTexture.Width, backgroundTexture.Height), Color.White);

            this.vendor.Draw(spriteBatch);

            foreach (var enemy in enemies)
            {
                enemy.Draw(this.spriteBatch);
            }

            this.gui.Draw(spriteBatch);

            this.player.Draw(spriteBatch);

            this.spriteBatch.End();
            base.Draw(gameTime);
        }

        private void AnimatePlayer()
        {
            if (countDown == 0)
            {
                //change direction
                if (isAttacking)
                {
                    if (this.player.PreviousDirection == "right")
                    {
                        this.player.Image = this.AnimationsRightAttack[indexFrame++];
                        if (indexFrame == this.AnimationsRightAttack.Length)
                        {
                            isAttacking = false;
                            indexFrame = 0;
                        }

                    }
                    else if (this.player.PreviousDirection == "left")
                    {
                        this.player.Image = this.AnimationsLeftAttack[indexFrame++];
                        if (indexFrame == this.AnimationsLeftAttack.Length)
                        {
                            isAttacking = false;
                            indexFrame = 0;
                        }
                    }
                }
                else if (this.player.PreviousDirection == "right")
                {
                    if (indexFrame >= AnimationsRight.Length)
                    {
                        indexFrame = 0;
                    }
                    else
                    {
                        this.player.Image = this.AnimationsRight[indexFrame++];
                    }

                }
                else
                {
                    if (indexFrame >= AnimationsLeft.Length)
                    {
                        indexFrame = 0;
                    }
                    else
                    {
                        this.player.Image = this.AnimationsLeft[indexFrame++];
                    }

                }

                countDown = 10;

            }

            countDown--;
        }

        private Item LootEnemy(string type)
        {
            int chance = rand.Next(0, 1);
            if (chance == 0)
            {
                if (type == "potion")

                {
                    return ItemGenerator.GetPotionItem(AllPotions);
                }
                else
                {
                    return ItemGenerator.GetEquipmentItem(AllEquipments);
                }
            }
            return null;
        }


        public bool ShopOpened { get; set; }
    }
}
