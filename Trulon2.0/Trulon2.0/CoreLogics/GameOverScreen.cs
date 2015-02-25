using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using GuideUIWP7;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Trulon.CoreLogics
{
    public class GameOverScreen : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        List<MenuButton> m_buttons = new List<MenuButton>();
        byte gameState;

        bool isActivatedNewGame = false;

        public GameOverScreen()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Resources/Images/Buttons";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            this.graphics.PreferredBackBufferWidth = 280;
            this.graphics.PreferredBackBufferHeight = 480;
            this.graphics.ApplyChanges();
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            TargetElapsedTime = TimeSpan.FromTicks(333333);

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

            MenuButton mb = new MenuButton(Content.Load<Texture2D>("KeyboardBtn"));
            Point p = new Point
            {
                X = (int) ((GraphicsDevice.Viewport.Width - mb.img.Width)*0.5f),
                Y = (int) ((GraphicsDevice.Viewport.Height - (mb.img.Height*3.0f))*0.5f)
            };
            mb.SetLocation(p);
            m_buttons.Add(mb);

            mb = new MenuButton(Content.Load<Texture2D>("MessageBoxBtn"));
            p.Y += (int)(mb.img.Height * 1.5f);
            mb.SetLocation(p);
            m_buttons.Add(mb);

        }

        protected override void UnloadContent()
        {
            Content.Unload();
            //this.Exit();
        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            {
                this.Exit();
            }

            if (isActivatedNewGame)
            {
                this.Exit();
                //new game
                isActivatedNewGame = false;
            }

            // if any Guide UIs are visible, return here.
            if (Guide.IsVisible)
            {
                base.Update(gameTime);
                return;
            }

            // check to see if the player is making a menu selection.  Since
            // we're only interested in a single touch-point, we can use the
            // simpler mouse input method.
            MouseState ms = Mouse.GetState();
            if (ms.LeftButton == ButtonState.Pressed)
            {
                // the player is pressing the screen
                foreach (MenuButton b in m_buttons)
                {
                    b.isPressed = b.HasPoint(ms.X, ms.Y);
                }
            }
            else if (ms.LeftButton == ButtonState.Released)
            {
                // the player has released the touchpoint
                for (int i = 0; i < m_buttons.Count; i++)
                {
                    MenuButton b = m_buttons[i];
                    if(b.HasPoint(ms.X, ms.Y) && b.isPressed)
                    {
                        b.isPressed = false;

                        switch (i)
                        {
                            case 0:
                                break;

                            case 1:
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            foreach (MenuButton b in m_buttons)
            {
                b.Update(gameTime.ElapsedGameTime.Milliseconds);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            // draw buttons
            foreach (MenuButton b in m_buttons)
            {
                b.Draw(spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
