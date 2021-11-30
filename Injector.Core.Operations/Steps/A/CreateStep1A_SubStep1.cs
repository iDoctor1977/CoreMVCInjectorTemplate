using Injector.Common;
using Injector.Common.Enums;
using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operations.Steps.A
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep1 : BaseStep, ISubStep<CaseDTOModelA, CaseDTOModelA>
    {
        public CreateStep1A_SubStep1(IServiceProvider service) : base(service) { }

        public CaseDTOModelA Execute(CaseDTOModelA caseDtoModel_IN)
        {
            // Read

            // Do

            // Write

            return caseDtoModel_IN;
        }
    }
}