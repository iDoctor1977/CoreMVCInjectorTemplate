using System;
using Injector.Common;
using Injector.Common.Extensions;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.Presenters
{
    public class ReadCustomPresenter : ABaseConsolidator<ReadModel, ReadViewModel>
    {
        public ReadCustomPresenter(IServiceProvider service) : base(service) { }

        public override ReadViewModel ToData(ReadModel model)
        {
            var viewModel = ToExternalData(model);
            viewModel.ReadingDay = model.ReadingDay.ToStandardString();

            return viewModel;
        }
    }
}