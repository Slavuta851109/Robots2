using System;

using Newtonsoft.Json;

namespace Robots.Application.UseCases.Decorators
{
    internal class LoggingUseCaseDecorator<TRequest, TResponse> : IUseCase<TRequest, TResponse>
        where TRequest : class
        where TResponse : class

    {
        private readonly IUseCase<TRequest, TResponse> decoratee;
        private readonly ILogger logger;

        public LoggingUseCaseDecorator(
            IUseCase<TRequest, TResponse> decoratee,
            ILogger logger)
        {
            this.decoratee = decoratee;
            this.logger = logger;
        }

        public TResponse Execute(TRequest request)
        {
            try
            {
                logger.Log($"REQUEST: {JsonConvert.SerializeObject(request)}");

                var response = this.decoratee.Execute(request);

                logger.Log($"RESPONSE: {JsonConvert.SerializeObject(response)}");

                return response;
            }
            catch (Exception ex)
            {
                logger.Log($"ERROR: {ex.Message}");
                throw;
            }
        }
    }
}
