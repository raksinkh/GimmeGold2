using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{

    public class GoldRush : Game
    {
        //test commit//wdwd
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private tile _robot, _bedrock, _dirt;
        private Texture2D G_tile, St_tile, Di_tile, La_tile;
        private Vector2 test_position;
        private Model mod1;
        public int[,] mode;
        public int g_height =600;//สูง
        public int g_width = 800;//ยาว


        //private object keys;

        public GoldRush()
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
            graphics.PreferredBackBufferHeight = g_height;
            graphics.PreferredBackBufferWidth = g_width;
            graphics.ApplyChanges();
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            test_position = new Vector2(0, 0);
            //Bed_tile = this.Content.Load<Texture2D>("Bedrock");
            //mod1.spriteBatch = new SpriteBatch(GraphicsDevice);

            mod1 = new Model(1);

            mod1.loadcontent();
            var r_mc = Content.Load<Texture2D>("robot");
            _robot = new tile(r_mc);
            _robot.position = new Vector2(100, 100);

            var wall_tile = Content.Load<Texture2D>("Bedrock_0");
            _bedrock = new tile(wall_tile);
            _bedrock.position = new Vector2(0, 0);

            var dirt_tile = Content.Load<Texture2D>("Dirt");
            _dirt = new tile(dirt_tile);

            G_tile = this.Content.Load<Texture2D>("GoldOre");
            St_tile = this.Content.Load<Texture2D>("Stone");
            Di_tile = this.Content.Load<Texture2D>("Dirt");
            La_tile = this.Content.Load<Texture2D>("Lava");


            // TODO: use this.Content to load your game content here
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


            // TODO: Add your update logic here
            _robot.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            mode = new int[,]
           {
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 2,2,1,1,2,3,4,1,2,3,4,1,3,2,1,4,3,3 },
            { 3,2,1,1,2,3,1,1,2,3,4,1,1,2,1,4,3,4 },
            { 4,2,2,1,2,3,4,4,2,3,1,1,3,2,1,4,3,2 },
            { 2,2,2,1,2,4,4,1,2,3,4,1,3,2,1,4,3,3 },
            { 2,2,2,1,2,3,4,1,2,3,4,1,3,2,1,4,1,1 },
            { 2,2,2,1,2,3,4,1,2,3,4,1,3,2,1,4,1,1 },
            { 2,2,2,1,2,3,4,1,2,3,4,1,3,2,1,4,1,1 },
           };

            // TODO: Add your drawing code here

            base.Draw(gameTime);
            spriteBatch.Begin();
            _robot.Draw(spriteBatch);
            _bedrock.DrawWall(spriteBatch, _bedrock.position);
            mod1.drawmodel(spriteBatch);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    test_position = new Vector2((j * 40) + 40, (i * 40) + 240);
                    int x = mode[i, j];
                    if (x == 1)
                    {
                        spriteBatch.Draw(G_tile, test_position, Color.White);
                    }
                    if (x == 2)
                    {
                        spriteBatch.Draw(St_tile, test_position, Color.White);
                    }
                    if (x == 3)
                    {
                        spriteBatch.Draw(Di_tile, test_position, Color.White);
                    }
                    if (x == 4)
                    {
                        spriteBatch.Draw(La_tile, test_position, Color.White);
                    }
                }
            }

            spriteBatch.End();


        }

    }
}
