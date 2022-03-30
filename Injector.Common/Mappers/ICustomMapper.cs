namespace Injector.Common.Mappers
{
    public interface ICustomMapper<TIn, TOut>
    {
        TOut Map(TIn value);
    }
}