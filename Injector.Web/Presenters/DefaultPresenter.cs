using AutoMapper;

namespace Injector.Web.Presenters
{
    public sealed class DefaultPresenter<TIn, TOut> : ABasePresenter<TIn, TOut>
    {
        public DefaultPresenter(IMapper mapper) : base(mapper) { }

        public override TOut ToViewData(TIn model)
        {
            var viewModel = ToExternalViewData(model);

            return viewModel;
        }
    }
}