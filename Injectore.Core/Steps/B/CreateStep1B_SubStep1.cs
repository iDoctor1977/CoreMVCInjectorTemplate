using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    public class CreateStep1B_SubStep1 : BaseStep, ISubStep<CaseDTOModelB, CaseDTOModelB>
    {
        public CreateStep1B_SubStep1(IServiceProvider service) : base(service) { }

        public CaseDTOModelB Execute(CaseDTOModelB value)
        {
            // Read

            // Do

            // Write

            return value;
        }
    }
}