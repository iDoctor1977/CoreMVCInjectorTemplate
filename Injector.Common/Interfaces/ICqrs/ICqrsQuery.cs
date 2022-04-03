namespace Injector.Common.Interfaces.ICqrs
{
    public interface ICqrsQuery<in TIn, out TOut>
    {
        TOut Execute(TIn model);
    }
}