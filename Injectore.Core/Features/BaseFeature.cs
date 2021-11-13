using Injector.Common.DTOModels;
using Injector.Common.ISteps.A;
using Injector.Common.ISteps.B;
using Injector.Common.ISuppliers;
using Injector.Core.CaseDTOModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Features
{
    public class BaseFeature
    {
        private readonly IDataSupplier _dataSupplier;

        private readonly ICreateStep1A<CaseDTOModelA> _createStep1A;
        private readonly ICreateStep2A<CaseDTOModelA> _createStep2A;
        private readonly ICreateStep3A<CaseDTOModelA> _createStep3A;
        private readonly IDeleteStep1A<CaseDTOModelA> _deleteStep1A;
        private readonly IDeleteStep2A<CaseDTOModelA> _deleteStep2A;

        private readonly ICreateStep1B<CaseDTOModelB> _createStep1B;
        private readonly ICreateStep2B<CaseDTOModelB> _createStep2B;
        private readonly ICreateStep3B<CaseDTOModelB> _createStep3B;

        public BaseFeature(IServiceProvider service)
        {
            _dataSupplier = service.GetRequiredService<IDataSupplier>();

            _createStep1A = service.GetRequiredService<ICreateStep1A<CaseDTOModelA>>();
            _createStep2A = service.GetRequiredService<ICreateStep2A<CaseDTOModelA>>();
            _createStep3A = service.GetRequiredService<ICreateStep3A<CaseDTOModelA>>();
            _deleteStep1A = service.GetRequiredService<IDeleteStep1A<CaseDTOModelA>>();
            _deleteStep2A = service.GetRequiredService<IDeleteStep2A<CaseDTOModelA>>();

            _createStep1B = service.GetRequiredService<ICreateStep1B<CaseDTOModelB>>();
            _createStep2B = service.GetRequiredService<ICreateStep2B<CaseDTOModelB>>();
            _createStep3B = service.GetRequiredService<ICreateStep3B<CaseDTOModelB>>();
        }

        public IDataSupplier BaseFeature_DataSupplier => _dataSupplier;

        #region STEPS

        public ICreateStep1A<CaseDTOModelA> BaseFeature_CreateStep1A => _createStep1A;
        public ICreateStep2A<CaseDTOModelA> BaseFeature_CreateStep2A => _createStep2A;
        public ICreateStep3A<CaseDTOModelA> BaseFeature_CreateStep3A => _createStep3A;
        public IDeleteStep1A<CaseDTOModelA> BaseFeature_DeleteStep1A => _deleteStep1A;
        public IDeleteStep2A<CaseDTOModelA> BaseFeature_DeleteStep2A => _deleteStep2A;

        public ICreateStep1B<CaseDTOModelB> BaseFeature_CreateStep1B => _createStep1B;
        public ICreateStep2B<CaseDTOModelB> BaseFeature_CreateStep2B => _createStep2B;
        public ICreateStep3B<CaseDTOModelB> BaseFeature_CreateStep3B => _createStep3B;

        #endregion
    }
}