namespace Injector.Common.Interfaces.Features
{
    public interface ICqrsCommand<T>
    {
        void Execute(T model);
    }
}