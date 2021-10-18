using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using FruitBurstBackend;

namespace FruitBurst
{
    public class FruitGridSprite : DrawableGameComponent{

        private FruitGrid fruitGrid;
        private SpriteBatch spriteBatch;
        private Texture2D fruitTexture;
        private Game1 game;

        public FruitGridSprite(Game1 game, FruitGrid fg) : base(game){
            this.game = game;
            fruitGrid = fg;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {  
            spriteBatch = new SpriteBatch(GraphicsDevice);
            fruitTexture = game.Content.Load<Texture2D>("fruit");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            for(int i=0; i< fruitGrid.Height; i ++){
                for(int j=0; j< fruitGrid.Width; j++){
                    if(fruitGrid.GetVisibilityAt(i,j)){
                        spriteBatch.Draw(fruitTexture, new Rectangle(i*100, j*100,100,100), Color.White);
                    }
                }
            } 
            spriteBatch.End();
            base.Draw(gameTime);
        }



    }
}