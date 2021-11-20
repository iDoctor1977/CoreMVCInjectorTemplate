using Injector.Common.ISteps.B;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    public class CreateStep1B : BaseStep, ICreateStep1B<CaseDTOModelB>
    {
        public CreateStep1B(IServiceProvider service) : base(service) { }

        public CaseDTOModelB Execute(CaseDTOModelB caseDtoModelB)
        {
            // Read

            // Do

            // Write
            
            return caseDtoModelB;
        }
    }
}