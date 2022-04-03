namespace Injector.Web.Interfaces.IConverters
{
    public interface IConverter<in TIn, out TOut>
    {
        TOut ToModelData(TIn viewModel);
    }
}