using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operations
{
    public class OperationsSupplier : AOperationsSupplier
    {
        public OperationsSupplier(IServiceProvider service) : base(service) { }

        protected override ICaseDTOModel<DTOModelA> CreateValueA_Pipeline(ICaseDTOModel<DTOModelA> caseDTOModelA)
        {
            caseDTOModelA = _createStep1A.AddStep(_createStep1A_SubStep1).AddStep(_createStep1A_SubStep2).Execute((CaseDTOModelA)caseDTOModelA);

            return caseDTOModelA;
        }
    }
}
