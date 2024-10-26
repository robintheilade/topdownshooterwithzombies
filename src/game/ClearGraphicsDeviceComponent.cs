using Microsoft.Xna.Framework;

namespace game
{
    public class ClearGraphicsDeviceComponent : DrawableGameComponent
    {
        public ClearGraphicsDeviceComponent(Game game) : base(game)
        {
            DrawOrder = (int)DrawOrders.CLEAR_GRAPHICS_DEVICE;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            Global.GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}