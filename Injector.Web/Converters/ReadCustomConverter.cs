using System;
using System.Globalization;
using AutoMapper;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.Converters
{
    public class ReadCustomConverter : ABaseConverter<ReadViewModel, ReadModel>
    {
        public ReadCustomConverter(IMapper mapper) : base(mapper) { }

        public override ReadModel ToModelData(ReadViewModel viewModel)
        {
            var model = ToExternalModelData(viewModel);

            model.ReadingDay = DateTime.Parse(viewModel.ReadingDay, CultureInfo.InvariantCulture);

            return model;
        }
    }
}