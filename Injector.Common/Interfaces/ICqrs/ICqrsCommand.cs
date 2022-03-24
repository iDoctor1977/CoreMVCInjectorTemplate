namespace Injector.Common.Interfaces.ICqrs
{
    public interface ICqrsCommand<T>
    {
        void Execute(T model);
    }
}