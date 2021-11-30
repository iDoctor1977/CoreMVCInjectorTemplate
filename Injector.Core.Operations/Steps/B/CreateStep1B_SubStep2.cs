using Injector.Common;
using Injector.Common.Enums;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operations.Steps.B
{
    public class CreateStep1B_SubStep2 : BaseStep, ISubStep<OperationResult<CaseDTOModelB>, OperationResult<CaseDTOModelB>>
    {
        public CreateStep1B_SubStep2(IServiceProvider service) : base(service) { }

        public OperationResult<CaseDTOModelB> Execute(OperationResult<CaseDTOModelB> caseDtoModel_IN)
        {
            if (caseDtoModel_IN.Status == OperationOutcomes.Success)
            {
                // Read

                // Do

                // Write
            }

            return caseDtoModel_IN;
        }
    }
}