using System;
using System.Reflection;
using Robots.Application.UseCases.Decorators;
using SimpleInjector;

namespace Robots.Application
{
    public static class ApplicationLayerBootstrapper
    {
        private static Assembly[] useCaseAssemblies = new[] { typeof(IUseCase<,>).Assembly };

        public static void Bootstrap(Container container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            container.Register(typeof(IUseCase<,>), useCaseAssemblies);
            container.RegisterDecorator(typeof(IUseCase<,>), typeof(LoggingUseCaseDecorator<,>));
        }
    }
}
