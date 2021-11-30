using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    [Root]
    public class CreateStep1B : RootPipelineBuilder<CaseDTOModelB, CaseDTOModelB>
    {
        public CreateStep1B(IServiceProvider service) : base(service) { }

        protected override OperationResult<CaseDTOModelB> ExecuteRootStep(CaseDTOModelB value)
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