namespace Injector.Common.Mappers
{
    public interface ICustomMapper<in TIn, out TOut>
    {
        TOut Map(TIn value);
    }
}