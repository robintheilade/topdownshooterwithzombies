using Microsoft.Xna.Framework.Graphics;


namespace game
{
    public class Sprite
    {
        private Texture2D _spriteSheet;

        public readonly int X;
        public readonly int Y;

        public readonly int Width;
        public readonly int Height;

        public Vector2 Position;

        public Vector2 Origin { get; }
        public Color Color;
        public float Rotation;
        public float Scale;

        public Sprite(Texture2D spriteSheet, int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;

            // Default everything
            Position = Vector2.Zero;
            Origin = Vector2.Zero;
            Color = Color.White;
            Rotation = 0f;
            Scale = 1f;
        }

        public void Draw()
        {
            Global.SpriteBatch.Draw(_spriteSheet, Position, new Rectangle(X, Y, Width, Height), Color, Rotation, Origin, Scale, 0, 1f);
        }
    }
}
