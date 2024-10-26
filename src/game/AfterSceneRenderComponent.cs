using Microsoft.Xna.Framework;

namespace game
{
    public class AfterSceneRenderComponent : DrawableGameComponent
    {
        public AfterSceneRenderComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.AFTER_SCENE_RENDER;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            Global.SpriteBatch.End();
        }
    }
}