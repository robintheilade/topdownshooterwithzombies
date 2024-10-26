using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace game
{
    public class BeforeSceneRenderComponent : DrawableGameComponent
    {
        public BeforeSceneRenderComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.BEFORE_SCENE_RENDER;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            Global.SpriteBatch.Begin(samplerState: SamplerState.PointWrap);
        }
    }
}