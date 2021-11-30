using Injector.Common;
using Injector.Common.Enums;
using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<OperationResult<CaseDTOModelA>, OperationResult<CaseDTOModelA>>
    {
        public DeleteStep1A(IServiceProvider service) : base(service) { }

        protected override OperationResult<CaseDTOModelA> ExecuteRootStep(OperationResult<CaseDTOModelA> caseDtoModel_IN)
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