using System;
using minicraft.Game;
using osu.Framework;

namespace minicraft.Desktop
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            using var host = Host.GetSuitableHost(@"minicraft-client");
            using var game = new Application();
            host.Run(game);
        }
    }
}
