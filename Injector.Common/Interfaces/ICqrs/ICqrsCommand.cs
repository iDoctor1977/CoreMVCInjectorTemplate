namespace Injector.Common.Interfaces.ICqrs
{
    public interface ICqrsCommand<in T> where T : ICqrsCommandBase
    {
        public void Execute(T model);
    }
}