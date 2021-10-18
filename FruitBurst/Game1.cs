using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using FruitBurstBackend;
using System;

namespace FruitBurst
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameState gameState;
        private FruitGridSprite fruitGridSprite;
        private ScoreSprite scoreSprite;
        private MouseState previous;
        private MouseState current;
        private const int maxScore = 300;

        private const int rectan = 100;
        private int counter = 0;
        private int timer = 0;
        private int interval =120;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            current = Mouse.GetState();
            previous = current;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = 1000;
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.ApplyChanges();
            gameState = new GameState(8,8);
            fruitGridSprite = new FruitGridSprite(this, gameState.Grid);
            scoreSprite = new ScoreSprite(this, gameState.ScoreAndLevelCounter);
            Components.Add(fruitGridSprite);
            Components.Add(scoreSprite);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            
            // TODO: Add your update logic here
            if(counter == interval){
                gameState.MakeFruitsAppear();
                counter = 0;
            }
            counter++;
            timer++;

            if(timer == 1000){
                interval /= 2;
                timer = 0;
                gameState.IncrementLevel();
            }


            previous = current;
            current = Mouse.GetState();
            if(current.LeftButton == ButtonState.Pressed && previous.LeftButton == ButtonState.Released){
                for(int i = 0; i < gameState.Grid.Height; i++){
                    for(int j = 0; j < gameState.Grid.Width; j++){
                        Rectangle r = new Rectangle(i*rectan,j*rectan, rectan, rectan);
                        if(r.Contains(current.Position.X, current.Position.Y) && gameState.Grid.GetVisibilityAt(i,j) ){
                            gameState.Grid[i,j].MakeInvisible();
                            gameState.UpdateScore(gameState.Grid[i,j]);
                        }
                    }
                }
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
