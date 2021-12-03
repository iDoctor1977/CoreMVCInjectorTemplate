using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.A
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep2 : ISubStep<CaseDTOModelA, CaseDTOModelA>
    {
        public CreateStep1A_SubStep2(IServiceProvider service) { }

        public CaseDTOModelA Execute(CaseDTOModelA caseDtoModel_IN)
        {
            // Read

            // Do

            // Write

            return caseDtoModel_IN;
        }
    }
}