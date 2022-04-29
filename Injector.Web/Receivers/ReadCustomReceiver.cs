using System;
using System.Globalization;
using Injector.Common;
using Injector.Common.Bases;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.Receivers
{
    public class ReadCustomReceiver : AConsolidatorBase<ReadViewModel, ReadModel>
    {
        public ReadCustomReceiver(IServiceProvider service) : base(service) { }

        public override ReadModel ToData(ReadViewModel viewModel)
        {
            var model = ToExternalData(viewModel);
            model.ReadingDay = DateTime.Parse(viewModel.ReadingDay, CultureInfo.InvariantCulture);

            return model;
        }
    }
}