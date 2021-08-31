using osu.Framework.Allocation;
using osu.Framework.Graphics.Containers;
using osu.Framework.Screens;

namespace minicraft.Game
{
    public sealed class Application : BaseApplication
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            var screens = new ScreenStack();

            Add(new DrawSizePreservingFillContainer
            {
                Child = screens
            });
        }

        protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
            => new DependencyContainer(base.CreateChildDependencies(parent));
    }
}
