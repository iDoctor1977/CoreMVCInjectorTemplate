using System;
using System.Globalization;
using AutoMapper;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.CustomMappers
{
    public class ReadModelMapper : ABaseCustomMapper<ReadViewModel, ReadModel>
    {
        public ReadModelMapper(IMapper mapper) : base(mapper) { }

        public override ReadModel Map(ReadViewModel viewModel)
        {
            var map = ExternalMap(viewModel);

            map.ReadingDay = DateTime.ParseExact(viewModel.ReadingDay, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture);

            return map;
        }
    }
}