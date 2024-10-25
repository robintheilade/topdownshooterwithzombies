using Microsoft.Xna.Framework;

namespace game
{
    public class ClearGraphicsDeviceComponent : DrawableGameComponent
    {
        public ClearGraphicsDeviceComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.ClearGraphicsDevice;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            G.GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}