using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace game
{
    public class InitializeGlobalsComponent : GameComponent
    {
        public InitializeGlobalsComponent(Game game) : base(game)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
            Global.GraphicsDevice = Game.GraphicsDevice;
            Global.SpriteBatch = new SpriteBatch(Global.GraphicsDevice);
        }
    }
}