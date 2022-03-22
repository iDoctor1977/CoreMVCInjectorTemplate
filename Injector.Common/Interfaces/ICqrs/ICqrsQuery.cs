namespace Injector.Common.Interfaces.ICqrs
{
    public interface ICqrsQuery<TIn, TOut>
    {
        TOut Execute(TIn model);
    }
}