using System;
using System.Globalization;
using AutoMapper;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.Converters
{
    public class ReadConverter : ABaseConverter<ReadViewModel, ReadModel>
    {
        public ReadConverter(IMapper mapper) : base(mapper) { }

        public override ReadModel ToModelData(ReadViewModel viewModel)
        {
            var model = ToExternalModelData(viewModel);

            model.ReadingDay = DateTime.Parse(viewModel.ReadingDay, CultureInfo.InvariantCulture);

            return model;
        }
    }
}