namespace Trulon.CoreLogics
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using global::Trulon.Enums;

    public class StateManager : Engine
    {
        private State gameState = State.start;
        private Texture2D backgroundMenu;
        private Texture2D backgroundCredits;
        private Texture2D backgroundControls;
        private Texture2D backgroundVictory;

        public StateManager()
        {
            this.CurrentMap = 1;
        }

        public int CurrentMap { get; set; }

        protected override void Initialize()
        {
            this.IsMouseVisible = false;
            base.Initialize();
        }
 
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.spriteBatch = new SpriteBatch(GraphicsDevice);
            Content.RootDirectory = "Resources";
            this.backgroundMenu = Content.Load<Texture2D>("Images/Screens/StartScreen");
            this.backgroundCredits = Content.Load<Texture2D>("Images/Screens/CreditsScreen");
            this.backgroundControls = Content.Load<Texture2D>("Images/Screens/ControlsScreen");
            this.backgroundVictory = Content.Load<Texture2D>("Images/Screens/VictoryScreen");
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }

            // Save previous state of the keyboard to determine single key presses
            this.previousKeyboardState = this.currentKeyboardState;

            // Read the current state of the keyboard and store it
            this.currentKeyboardState = Keyboard.GetState();
            
            if (this.gameState == State.start)
            {
                // Allows the game to exit
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                {
                    this.Exit();
                }

                if (currentKeyboardState.IsKeyDown(Keys.Enter))
                {
                    this.gameState = State.play;
                }

                if (currentKeyboardState.IsKeyDown(Keys.C))
                {
                    this.gameState = State.credits;
                }

                if (currentKeyboardState.IsKeyDown(Keys.V))
                {
                    this.gameState = State.controls;
                }
            }

            if (currentKeyboardState.IsKeyDown(Keys.Back) && 
                (this.gameState == State.controls ||
                this.gameState == State.credits))
            {
                this.gameState = State.start;
            }

            if (this.gameState == State.play)
            {
                if (!this.Player.IsAlive)
                {
                    this.gameState = State.start;
                    base.Initialize();
                }

                if (this.YouWon)
                {
                    this.YouWon = false;
                    this.gameState = State.win;
                }

                base.Update(gameTime);
            }

            if (this.gameState == State.win && currentKeyboardState.IsKeyDown(Keys.Enter))
            {
                this.gameState = State.start;
                base.Initialize();
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            if (this.gameState == State.start)
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                this.spriteBatch.Draw(this.backgroundMenu, new Rectangle(0, 0, this.backgroundMenu.Width, this.backgroundMenu.Height), Color.White);
                spriteBatch.End();
            }

            if (this.gameState == State.credits)
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                this.spriteBatch.Draw(this.backgroundCredits, new Rectangle(0, 0, this.backgroundCredits.Width, this.backgroundCredits.Height), Color.White);
                spriteBatch.End();
            }

            if (this.gameState == State.controls)
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                this.spriteBatch.Draw(this.backgroundControls, new Rectangle(0, 0, this.backgroundControls.Width, this.backgroundControls.Height), Color.White);
                spriteBatch.End();
            }

            if (this.gameState == State.win)
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                this.spriteBatch.Draw(this.backgroundVictory, new Rectangle(0, 0, this.backgroundVictory.Width, this.backgroundVictory.Height), Color.White);
                spriteBatch.End(); 
            }

            if (this.gameState == State.play)
            {
                base.Draw(gameTime);
            }
        }
    }
}
