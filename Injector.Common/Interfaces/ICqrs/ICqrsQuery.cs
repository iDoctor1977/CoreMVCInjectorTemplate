namespace Injector.Common.Interfaces.ICqrs
{
    public interface ICqrsQuery<in TIn, TOut> where TIn : ICqrsQueryBase
    {
        public TOut Execute(TIn model);
    }
}