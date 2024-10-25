using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace game
{
    public class BeforeSceneRenderComponent : DrawableGameComponent
    {
        public BeforeSceneRenderComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.BeforeSceneRender;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            G.SpriteBatch.Begin(samplerState: SamplerState.PointWrap);
        }
    }
}