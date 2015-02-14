#region Using Statements
using System;
using System.Collections.Generic;
using GameEngine;
using GameEngine.Models.Entities;
using GameEngine.Models.Entities.NPCs.Allies;
using GameEngine.Models.Entities.Players;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace Trulon2._0
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Engine : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Player player;

        private KeyboardState currentKeyboardState;
        private KeyboardState previousKeyboardState;

        private KeyboardState enemyCurrentKey;
        private KeyboardState enemyPreviousKey;

        private MouseState currentMouseState;
        private MouseState previousMouseState;

        private float playerMoveSpeed;

        public Engine()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Resources/Images";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            player = new Barbarian();
            playerMoveSpeed = 5.0F;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            //Load the player resources
            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            player.Initialize(Content.Load<Texture2D>(Assets.BarbarianImages[0]), playerPosition);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //Save previous state of the keyboard to determine single key presses
            previousKeyboardState = currentKeyboardState;
            enemyPreviousKey = enemyCurrentKey;
            previousMouseState = currentMouseState;

            //Read the current state of the keyboard and store it
            currentKeyboardState = Keyboard.GetState();
            enemyCurrentKey = Keyboard.GetState();
            currentMouseState = Mouse.GetState();

            //Update player
            this.UpdatePlayer(gameTime, player);

            base.Update(gameTime);
        }

        private void UpdatePlayer(GameTime gameTime, Player player)
        {
            //Keyboard input
            if (currentKeyboardState.IsKeyDown(Keys.Left))
            {
                player.Position = new Vector2(player.Position.X - playerMoveSpeed, player.Position.Y);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Right))
            {
                player.Position = new Vector2(player.Position.X + playerMoveSpeed, player.Position.Y);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Up))
            {
                player.Position = new Vector2(player.Position.X, player.Position.Y - playerMoveSpeed);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Down))
            {
                player.Position = new Vector2(player.Position.X, player.Position.Y + playerMoveSpeed);
            }
            //this.player.Position.X = 5f;
            //Make sure that player doesn't go out of bounds
            player.Position = new Vector2(MathHelper.Clamp(player.Position.X, 0, GraphicsDevice.Viewport.Width - player.Image.Width),
                                            MathHelper.Clamp(player.Position.Y, 0, GraphicsDevice.Viewport.Height - player.Image.Height));
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            player.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
