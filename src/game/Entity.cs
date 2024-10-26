using System;

namespace game
{
    public class Entity : GameComponent, IDrawable
    {
        public bool Visible => _visible;
        private bool _visible;

        public int DrawOrder => _drawOrder;
        private int _drawOrder;

        public readonly Sprite Sprite;

        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public Entity(Game game, Sprite sprite) : base(game)
        {
            Sprite = sprite;
        }

        public override void Initialize()
        {
            UpdateOrder = 0;
        }

        public override void Update(GameTime gameTime)
        {

        }
        
        public virtual void Draw(GameTime gameTime)
        {
            Sprite.Draw();
        }
    }
}
