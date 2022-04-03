using AutoMapper;
using Injector.Web.Interfaces.IPresenters;

namespace Injector.Web.Presenters
{
    public abstract class ABasePresenter<TIn, TOut> : IPresenter<TIn, TOut>
    {
        private readonly IMapper _mapper;

        protected ABasePresenter(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected TOut ToExternalViewData(TIn model)
        {
            var viewModel = _mapper.Map<TOut>(model);

            return viewModel;
        }

        public abstract TOut ToViewData(TIn model);
    }
}