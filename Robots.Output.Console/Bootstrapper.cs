using Robots.Application;
using Robots.Output.AConsole.Infrastructure;
using SimpleInjector;

namespace Robots.Output.AConsole.Infrastructure
{
    public static class Bootstrapper
    {
        public static Container Bootstrap(Container container)
        {
            ApplicationLayerBootstrapper.Bootstrap(container);
            container.RegisterInstance<ILogger>(new DebugLogger());

            return container;
        }
    }
}
