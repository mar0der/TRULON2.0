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

        Texture2D player;
        Rectangle playerBound;
        public readonly double PlayerSpeed = 5f;

        private Vendor vendor;

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

            player = Content.Load<Texture2D>(Assets.BarbarianImages[0]);
            playerBound = new Rectangle(0, 0, player.Width, player.Height);

            vendor = new Vendor("Bai Gosho",
                Content.Load<Texture2D>(Assets.Vendor[0]),
                new Rectangle(15, 15,
                    Content.Load<Texture2D>(Assets.Vendor[0]).Width,
                    Content.Load<Texture2D>(Assets.Vendor[0]).Height));

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

            base.Update(gameTime);
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
            spriteBatch.Draw(player, playerBound, Color.White); //Draws our current player
            spriteBatch.Draw(vendor.Image,vendor.Bounds,Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
