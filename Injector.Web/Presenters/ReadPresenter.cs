using AutoMapper;
using Injector.Common.Extensions;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.Presenters
{
    public class ReadPresenter : ABasePresenter<ReadModel, ReadViewModel>
    {
        public ReadPresenter(IMapper mapper) : base(mapper) { }

        public override ReadViewModel ToViewData(ReadModel model)
        {
            var viewModel = ToExternalViewData(model);
            viewModel.ReadingDay = model.ReadingDay.ToStandardString();

            return viewModel;
        }
    }
}