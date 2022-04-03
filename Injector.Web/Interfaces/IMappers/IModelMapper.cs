namespace Injector.Web.Interfaces.IMappers
{
    public interface IModelMapper<in TIn, out TOut>
    {
        TOut ToModelData(TIn viewModel);
    }
}