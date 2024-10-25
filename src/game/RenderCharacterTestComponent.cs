using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace game
{
    public class RenderCharacterTestComponent : DrawableGameComponent
    {
        private Texture2D texture;

        public RenderCharacterTestComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.RenderCharacterTest;
        }

        public override void Initialize()
        {
            base.Initialize();
            texture = Game.Content.Load<Texture2D>("gfx/spritesheet_characters");
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            G.SpriteBatch.Draw(texture, G.GraphicsDevice.Viewport.Bounds.Size.ToVector2() / 2, new Rectangle(164, 88, 49, 43), Color.White);
        }
    }
}