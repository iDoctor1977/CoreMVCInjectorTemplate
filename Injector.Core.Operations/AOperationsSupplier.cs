using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Common.ISuppliers;
using Injector.Core.Operations.Steps.A;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Operations
{
    public abstract class AOperationsSupplier : IOperationsSupplier
    {
        protected readonly CreateStep1A _createStep1A;
        protected readonly CreateStep1A_SubStep1 _createStep1A_SubStep1;
        protected readonly CreateStep1A_SubStep2 _createStep1A_SubStep2;

        public AOperationsSupplier(IServiceProvider service)
        {
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep1A_SubStep1 = service.GetRequiredService<CreateStep1A_SubStep1>();
            _createStep1A_SubStep2 = service.GetRequiredService<CreateStep1A_SubStep2>();
        }

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CreateValueA => CreateValueA_Pipeline;

        protected abstract ICaseDTOModel<DTOModelA> CreateValueA_Pipeline(ICaseDTOModel<DTOModelA> caseDTOModelA);
    }
}
