using Injector.Common.ISteps.B;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    public class CreateStep2B : BaseStep, ICreateStep2B<CaseDTOModelB>
    {
        public CreateStep2B(IServiceProvider service) : base(service) { }

        public CaseDTOModelB Execute(CaseDTOModelB dtoModelB)
        {
            // Read

            // Do

            // Write

            return dtoModelB;
        }
    }
}