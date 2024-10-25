using System;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework;

namespace game
{
    public static class Program
    {
        public static void Main()
        {
            using (var game = new Game())
            {
                game.Content.RootDirectory = "Content";
                game.IsMouseVisible = true;
                game.Window.AllowUserResizing = true;

                new GraphicsDeviceManager(game);

                Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(type => type.IsClass)
                    .Where(type => !type.IsAbstract)
                    .Where(type => type.IsAssignableTo(typeof(IGameComponent)))
                    .Select(type => (IGameComponent)Activator.CreateInstance(type, [game]))
                    .ToList()
                    .ForEach(component => game.Components.Add(component))
                    ;

                game.Run();
            }
        }
    }
}
