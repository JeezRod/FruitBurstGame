using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using FruitBurstBackend;

namespace FruitBurst
{
    public class ScoreSprite : DrawableGameComponent{
        
        private ScoreAndLevel scoreAndLevel;
        private SpriteFont font;
        private Game1 game;
        private SpriteBatch spriteBatch;
        public ScoreSprite(Game1 game, ScoreAndLevel scoreAndLevel): base(game){
            this.game = game;
            this.scoreAndLevel = scoreAndLevel;
        }
        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            font = game.Content.Load<SpriteFont>("font");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "My Text", new Vector2(5,800), Color.Black);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}