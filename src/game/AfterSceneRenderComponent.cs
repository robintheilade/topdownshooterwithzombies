using Microsoft.Xna.Framework;

namespace game
{
    public class AfterSceneRenderComponent : DrawableGameComponent
    {
        public AfterSceneRenderComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.AfterSceneRender;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            G.SpriteBatch.End();
        }
    }
}