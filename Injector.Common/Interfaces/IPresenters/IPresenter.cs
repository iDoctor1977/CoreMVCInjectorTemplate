namespace Injector.Common.Interfaces.IPresenters
{
    public interface IPresenter<TIn, TOut>
    {
        TOut ToViewData(TIn model);
    }
}