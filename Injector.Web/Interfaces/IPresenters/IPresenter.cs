namespace Injector.Web.Interfaces.IPresenters
{
    public interface IPresenter<in TIn, out TOut>
    {
        TOut ToViewData(TIn model);
    }
}