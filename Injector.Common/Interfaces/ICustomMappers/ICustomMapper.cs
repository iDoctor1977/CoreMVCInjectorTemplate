namespace Injector.Common.Interfaces.ICustomMappers
{
    public interface ICustomMapper
    {
        TOut Map<TIn, TOut>(TIn model);
    }
}