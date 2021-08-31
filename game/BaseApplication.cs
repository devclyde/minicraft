using minicraft.Game.Stores;
using osu.Framework.Allocation;
using osu.Framework.Configuration;
using osu.Framework.Graphics.Textures;
using osu.Framework.IO.Stores;
using ofGame = osu.Framework.Game;
using static minicraft.Resources.ResourceAssembly;

namespace minicraft.Game
{
    public abstract class BaseApplication : ofGame
    {
        private DependencyContainer dependencies;

        [BackgroundDependencyLoader]
        private void load(FrameworkConfigManager config)
        {
            Resources.AddStore(new DllResourceStore(Assembly));

            dependencies.Cache(new TextureStore(Textures));
            dependencies.Cache(new NearestTextureStore(Textures));

            config.GetBindable<FrameSync>(FrameworkSetting.FrameSync).Value = FrameSync.Unlimited;

            Host.Window.Title = "minicraft";
        }

        protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
            => dependencies = new(base.CreateChildDependencies(parent));
    }
}
