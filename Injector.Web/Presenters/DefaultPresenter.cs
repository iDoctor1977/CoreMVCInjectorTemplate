using System;
using Injector.Common;
using Injector.Common.Bases;

namespace Injector.Web.Presenters
{
    public sealed class DefaultPresenter<TIn, TOut> : AConsolidatorBase<TIn, TOut>
    {
        public DefaultPresenter(IServiceProvider service) : base(service) { }

        public override TOut ToData(TIn model)
        {
            var viewModel = ToExternalData(model);

            return viewModel;
        }
    }
}