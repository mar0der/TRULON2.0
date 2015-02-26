namespace Trulon.CoreLogics
{
    using global::Trulon.Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class StateManager : Engine
    {
        private State gameState = State.start;
        private Texture2D backgroundMenu;
        private Texture2D backgroundCredits;
        private Texture2D backgroundControls;
        bool isActivatedNewGame = false;

        public StateManager()
        {
            this.CurrentMap = 1;
        }

        public int CurrentMap { get; set; }
        protected override void Initialize()
        {
            IsMouseVisible = false;
            
            base.Initialize();
        }
 
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Content.RootDirectory = "Resources";
            backgroundMenu = Content.Load<Texture2D>("Images/Screens/StartScreen");
            backgroundCredits = Content.Load<Texture2D>("Images/Screens/CreditsScreen");
            backgroundControls = Content.Load<Texture2D>("Images/Screens/ControlsScreen");
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
            
            if (this.gameState == State.start)
            {
                // Allows the game to exit
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                {
                    this.Exit();
                }
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

            if (currentKeyboardState.IsKeyDown(Keys.Back) && 
                (gameState == State.controls ||
                gameState == State.credits))
            {
                this.gameState = State.start;
            }

            if (this.gameState == State.play)
            {
                if (!this.player.IsAlive)
                {
                    gameState = State.start;
                    base.Initialize();
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
                this.spriteBatch.Draw(backgroundMenu, new Rectangle(0, 0, backgroundMenu.Width, backgroundMenu.Height), Color.White);
                spriteBatch.End();
            }
            if (this.gameState == State.credits)
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                this.spriteBatch.Draw(backgroundCredits, new Rectangle(0, 0, backgroundCredits.Width, backgroundCredits.Height), Color.White);
                spriteBatch.End();
            }
            if (this.gameState == State.controls)
            {
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Begin();
                this.spriteBatch.Draw(backgroundControls, new Rectangle(0, 0, backgroundControls.Width, backgroundControls.Height), Color.White);
                spriteBatch.End();
            }
            if (this.gameState == State.play)
            {
                base.Draw(gameTime);
            }
            
        }
    }
}
