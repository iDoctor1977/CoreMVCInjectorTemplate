using Injector.Common;
using Injector.Common.Enums;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.B
{
    public class CreateStep1B_SubStep2 : ISubStep<OperationResult<CaseDTOModelB>, OperationResult<CaseDTOModelB>>
    {
        public CreateStep1B_SubStep2(IServiceProvider service) { }

        public OperationResult<CaseDTOModelB> Execute(OperationResult<CaseDTOModelB> caseDtoModel_IN)
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