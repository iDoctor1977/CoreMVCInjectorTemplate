using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    public class CreateStep1B_SubStep2 : BaseStep, ISubStep<CaseDTOModelB, CaseDTOModelB>
    {
        public CreateStep1B_SubStep2(IServiceProvider service) : base(service) { }

        public CaseDTOModelB Execute(CaseDTOModelB dtoModelB)
        {
            // Read

            // Do

            // Write

            return dtoModelB;
        }
    }
}