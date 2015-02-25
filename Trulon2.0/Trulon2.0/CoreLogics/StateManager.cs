using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Trulon.Config;
using Trulon.Enums;
using Trulon.GUI;
using Trulon.Models;
using Trulon.Models.Entities;
using Trulon.Models.Entities.NPCs;
using Trulon.Models.Entities.NPCs.Allies;
using Trulon.Models.Entities.NPCs.Enemies;
using Trulon.Models.Entities.Players;
using Trulon.Models.Items.Equipments;
using Trulon.Models.Items.Potions;
using Trulon.Models.Maps;

namespace Trulon.CoreLogics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using GuideUIWP7;

    public class StateManager : Engine
    {
        private State gameState = State.start;
        List<MenuButton> m_buttons = new List<MenuButton>();
        bool isActivatedNewGame = false;
        private MouseState ms;

        public StateManager()
        {
            
        }


        protected override void Initialize()
        {
            this.graphics.PreferredBackBufferWidth = 280;
            this.graphics.PreferredBackBufferHeight = 480;
            this.graphics.ApplyChanges();
            IsMouseVisible = true;
            
            base.Initialize();
        }

 
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Content.RootDirectory = "Resources/Images/Buttons";
            MenuButton mb = new MenuButton(Content.Load<Texture2D>("KeyboardBtn"));
            Point p = new Point
            {
                X = (int)((GraphicsDevice.Viewport.Width - mb.img.Width) * 0.5f),
                Y = (int)((GraphicsDevice.Viewport.Height - (mb.img.Height * 3.0f)) * 0.5f)
            };
            mb.SetLocation(p);
            m_buttons.Add(mb);

            mb = new MenuButton(Content.Load<Texture2D>("MessageBoxBtn"));
            p.Y += (int)(mb.img.Height * 1.5f);
            mb.SetLocation(p);
            m_buttons.Add(mb);
            Content.RootDirectory = "Resources";
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Save previous state of the keyboard to determine single key presses
            previousKeyboardState = currentKeyboardState;
            //Read the current state of the keyboard and store it
            currentKeyboardState = Keyboard.GetState();
            

            if (currentKeyboardState.IsKeyDown(Keys.D9))
            {
                this.gameState = State.play;
            }

            if (this.gameState == State.start)
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
                ms = Mouse.GetState();
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
                        if (b.HasPoint(ms.X, ms.Y) && b.isPressed)
                        {
                            b.isPressed = false;

                            switch (i)
                            {
                                case 0:
                                    this.gameState = State.play;
                                    break;

                                case 1:
                                    this.gameState = State.end;
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
            }

            if (this.gameState == State.play)
            {
                if (!this.player.IsAlive)
                {
                    gameState = State.start;
                }
                base.Update(gameTime);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            if (this.gameState == State.start)
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                // draw buttons
                foreach (MenuButton b in m_buttons)
                {
                    b.Draw(spriteBatch);
                }
                spriteBatch.End();
            }
            if (this.gameState == State.play)
            {
                base.Draw(gameTime); 
            }
            
        }
    }
}
