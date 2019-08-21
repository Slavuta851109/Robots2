namespace Robots.Application
{
    public interface IUseCase<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
        TResponse Execute(TRequest request);
    }
}