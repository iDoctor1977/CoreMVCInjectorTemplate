namespace Injector.Common.Interfaces.ICqrs
{
    public interface ICqrsCommand<in T>
    {
        void Execute(T model);
    }
}