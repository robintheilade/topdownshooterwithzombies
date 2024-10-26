using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace game
{
    public class RenderCharacterTestComponent : DrawableGameComponent
    {
        private Texture2D spriteSheet;

        private Entity entity;
        private Sprite sprite;

        public RenderCharacterTestComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.RENDER_CHARACTER_TEST;
        }

        public override void Initialize()
        {
            base.Initialize();
            spriteSheet = Game.Content.Load<Texture2D>("gfx/spritesheet_characters");
            sprite = new(spriteSheet, 0, 0, 58, 44);
            entity = new(Game, sprite);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            entity.Draw(gameTime);
        }
    }
}