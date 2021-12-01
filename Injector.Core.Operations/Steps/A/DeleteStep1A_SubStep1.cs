using Injector.Common;
using Injector.Common.Enums;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.A
{
    [Leaf(nameof(DeleteStep1A))]
    public class DeleteStep1A_SubStep1 : BaseStep, ISubStep<OperationResult<CaseDTOModelA>, OperationResult<CaseDTOModelA>>
    {
        public DeleteStep1A_SubStep1(IServiceProvider service) : base(service) { }

        public OperationResult<CaseDTOModelA> Execute(OperationResult<CaseDTOModelA> caseDtoModel_IN)
        {
            if (caseDtoModel_IN.Status == OperationsStatus.Success)
            {
                // Read

                // Do

                // Write
            }

            return caseDtoModel_IN;
        }
    }
}