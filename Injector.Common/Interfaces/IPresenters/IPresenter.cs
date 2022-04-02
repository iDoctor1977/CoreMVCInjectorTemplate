namespace Injector.Common.Interfaces.IPresenters
{
    public interface IPresenter<in TIn, out TOut>
    {
        TOut ToViewData(TIn model);
    }
}