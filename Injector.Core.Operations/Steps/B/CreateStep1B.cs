using Injector.Common;
using Injector.Common.Enums;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.B
{
    [Root]
    public class CreateStep1B : RootPipelineBuilder<OperationResult<CaseDTOModelB>, OperationResult<CaseDTOModelB>>
    {
        public CreateStep1B(IServiceProvider service) { }

        protected override OperationResult<CaseDTOModelB> ExecuteRootStep(OperationResult<CaseDTOModelB> caseDtoModel_IN)
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