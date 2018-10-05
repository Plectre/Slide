using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Slide2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D plan_1;
        Texture2D plan_2;
        Texture2D plan_3;
        Texture2D indian_text;
        Background background_1;
        Background background_2;
        Background background_3;
        Player indian;
        KeyboardState kb;

        float speedX;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            

            plan_1 = Content.Load<Texture2D>("assets/img/plan_1");
            plan_2 = Content.Load<Texture2D>("assets/img/plan_2");
            plan_3 = Content.Load<Texture2D>("assets/img/plan_3");
            indian_text = Content.Load<Texture2D>("assets/img/indian");

            background_1 = new Background(plan_1, 3);
            background_2 = new Background(plan_2, 2);
            background_3 = new Background(plan_3, 1);
            
            //indian = new Player(indian_text);
            
            indian = new Player(indian_text);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            // @param speed
            background_1.Update(3.5f);
            background_2.Update(2f);
            background_3.Update(1f);
            kb = Keyboard.GetState();
            indian.update();

            if (kb.IsKeyDown(Keys.Right))
            {
                speedX = background_3.speed;
                background_3.Update(speedX * 2f);
                speedX = background_2.speed;
                background_2.Update(speedX * 2f);
                speedX = background_1.speed;
                background_1.Update(speedX * 2f);
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            background_3.Draw(spriteBatch);
            background_2.Draw(spriteBatch);
            background_1.Draw(spriteBatch);

            indian.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
