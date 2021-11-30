using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep2 : BaseStep, ISubStep<CaseDTOModelA, CaseDTOModelA>
    {
        public CreateStep1A_SubStep2(IServiceProvider service) : base(service) { }

        public OperationResult<CaseDTOModelA> Execute(OperationResult<CaseDTOModelA> caseDtoModel_IN)
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