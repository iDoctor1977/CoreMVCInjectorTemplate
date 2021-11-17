using Injector.Common.ISteps.B;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    public class CreateStep3B : BaseStep, ICreateStep3B<CaseDTOModelB>
    {
        public CreateStep3B(IServiceProvider service) : base(service) { }

        public CaseDTOModelB Execute(CaseDTOModelB dtoModelB)
        {
            // Read

            // Do

            // Write

            return dtoModelB;
        }
    }
}