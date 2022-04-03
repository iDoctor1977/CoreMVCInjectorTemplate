using AutoMapper;
using Injector.Common.Extensions;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.Presenters
{
    public class ReadCustomPresenter : ABasePresenter<ReadModel, ReadViewModel>
    {
        public ReadCustomPresenter(IMapper mapper) : base(mapper) { }

        public override ReadViewModel ToViewData(ReadModel model)
        {
            var viewModel = ToExternalViewData(model);
            viewModel.ReadingDay = model.ReadingDay.ToStandardString();

            return viewModel;
        }
    }
}