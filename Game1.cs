using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2_Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Texture2D rectangleTexture;

        Rectangle circleRect;

        SpriteFont titleFont;

        Rectangle headRect, mouthRect, leftEyeRect, rightEyeRect;

        private SpriteFont font;
        private int Hello = 0;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.Window.Title = "Lesson 2 - Scaling";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 800;  
            _graphics.PreferredBackBufferHeight = 500;   
            _graphics.ApplyChanges();

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            headRect = new Rectangle(150, 0, 500, 500);
            leftEyeRect = new Rectangle(250, 100, 100, 75);
            rightEyeRect = new Rectangle(450, 100, 100, 75);
            mouthRect = new Rectangle(300, 350, 200, 50);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            {
                _spriteBatch = new SpriteBatch(GraphicsDevice);

                // TODO: use this.Content to load your game content here

                circleTexture = Content.Load<Texture2D>("whitecircle");
                rectangleTexture = Content.Load<Texture2D>("whiterectangle");
                font = Content.Load<SpriteFont>("Hello");

            }
           

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(circleTexture, new Rectangle(200, 120, 350, 350), Color.Wheat);
            _spriteBatch.Draw(circleTexture, new Rectangle(100, 70, 200, 200), Color.Wheat);
            _spriteBatch.Draw(circleTexture, new Rectangle(420, 80, 200, 200), Color.Wheat);
            _spriteBatch.Draw(circleTexture, new Rectangle(350, 350, 80, 80), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(270, 230, 100, 100), Color.White);
            _spriteBatch.Draw(circleTexture, new Rectangle(400, 230, 100, 100), Color.White);
            _spriteBatch.Draw(circleTexture, new Rectangle(410, 280, 30, 30), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(310, 280, 30, 30), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(310, 180, 30, 30), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(300, 180, 30, 30), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(290, 180, 30, 30), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(400, 180, 30, 30), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(410, 180, 30, 30), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(420, 180, 30, 30), Color.Black);

            _spriteBatch.DrawString(titleFont, "Hello", new Vector2(100, 100), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
