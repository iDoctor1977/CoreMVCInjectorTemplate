using System;
using Injector.Common;

namespace Injector.Web.Receivers
{
    public sealed class DefaultReceiver<TIn, TOut> : ABaseConsolidator<TIn, TOut>
    {
        public DefaultReceiver(IServiceProvider service) : base(service) { }

        public override TOut ToData(TIn viewModel)
        {
            var model = ToExternalData(viewModel);

            return model;
        }
    }
}