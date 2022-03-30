using System;
using AutoMapper;
using Injector.Common.Extensions;
using Injector.Common.Interfaces.IPresenters;
using Injector.Common.Models;
using Injector.Web.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web.Presenters
{
    public class ReadPresenter : IPresenter<ReadModel, ReadViewModel>
    {
        private readonly IMapper _mapper;
        public IConfiguration Configuration { get; }

        public ReadPresenter(IServiceProvider service)
        {
            _mapper = service.GetRequiredService<IMapper>();
            Configuration = service.GetRequiredService<IConfiguration>();
        }
        public ReadViewModel ToViewData(ReadModel model)
        {
            var readingDate = model.ReadingDay.ToStandardString();

            var readViewModel = _mapper.Map<ReadViewModel>(model);
            readViewModel.ReadingDay = readingDate;

            return readViewModel;
        }
    }
}