using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<CaseDTOModelA, CaseDTOModelA>
    {
        public DeleteStep1A(IServiceProvider service) : base(service) { }

        protected override OperationResult<CaseDTOModelA> ExecuteRootStep(CaseDTOModelA value)
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