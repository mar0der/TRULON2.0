namespace Trulon.CoreLogics
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using global::Trulon.Enums;
    using global::Trulon.Exceptions;

    using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
    using Keys = Microsoft.Xna.Framework.Input.Keys;

    public class StateManager : Engine
    {
        private State gameState = State.Start;
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
            try
            {
                base.Initialize();
            }
            catch (ContentLoadException ce)
            {
                throw new ResourcesNotFoundException(ce.Message);
            }
        }
 
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.SpriteBatch = new SpriteBatch(GraphicsDevice);
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
            this.PreviousKeyboardState = this.CurrentKeyboardState;

            // Read the current state of the keyboard and store it
            this.CurrentKeyboardState = Keyboard.GetState();
            
            if (this.gameState == State.Start)
            {
                // Allows the game to exit
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                {
                    this.Exit();
                }

                if (CurrentKeyboardState.IsKeyDown(Keys.Enter))
                {
                    this.gameState = State.Play;
                }

                if (CurrentKeyboardState.IsKeyDown(Keys.C))
                {
                    this.gameState = State.Credits;
                }

                if (CurrentKeyboardState.IsKeyDown(Keys.V))
                {
                    this.gameState = State.Controls;
                }
            }

            if (CurrentKeyboardState.IsKeyDown(Keys.Back) && 
                (this.gameState == State.Controls ||
                this.gameState == State.Credits))
            {
                this.gameState = State.Start;
            }

            if (this.gameState == State.Play)
            {
                if (!this.Player.IsAlive)
                {
                    this.gameState = State.Start;
                    base.Initialize();
                }

                if (this.YouWon)
                {
                    this.YouWon = false;
                    this.gameState = State.Won;
                }

                base.Update(gameTime);
            }

            if (this.gameState == State.Won && CurrentKeyboardState.IsKeyDown(Keys.Enter))
            {
                this.gameState = State.Start;
                base.Initialize();
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            if (this.gameState == State.Start)
            {
                GraphicsDevice.Clear(Color.Black);
                SpriteBatch.Begin();
                this.SpriteBatch.Draw(this.backgroundMenu, new Rectangle(0, 0, this.backgroundMenu.Width, this.backgroundMenu.Height), Color.White);
                SpriteBatch.End();
            }

            if (this.gameState == State.Credits)
            {
                GraphicsDevice.Clear(Color.Black);
                SpriteBatch.Begin();
                this.SpriteBatch.Draw(this.backgroundCredits, new Rectangle(0, 0, this.backgroundCredits.Width, this.backgroundCredits.Height), Color.White);
                SpriteBatch.End();
            }

            if (this.gameState == State.Controls)
            {
                GraphicsDevice.Clear(Color.Black);
                SpriteBatch.Begin();
                this.SpriteBatch.Draw(this.backgroundControls, new Rectangle(0, 0, this.backgroundControls.Width, this.backgroundControls.Height), Color.White);
                SpriteBatch.End();
            }

            if (this.gameState == State.Won)
            {
                GraphicsDevice.Clear(Color.Black);
                SpriteBatch.Begin();
                this.SpriteBatch.Draw(this.backgroundVictory, new Rectangle(0, 0, this.backgroundVictory.Width, this.backgroundVictory.Height), Color.White);
                SpriteBatch.End(); 
            }

            if (this.gameState == State.Play)
            {
                base.Draw(gameTime);
            }
        }
    }
}
