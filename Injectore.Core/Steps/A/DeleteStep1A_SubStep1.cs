using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Leaf(nameof(DeleteStep1A))]
    public class DeleteStep1A_SubStep1 : BaseStep, ISubStep<CaseDTOModelA, CaseDTOModelA>
    {
        public DeleteStep1A_SubStep1(IServiceProvider service) : base(service) { }

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