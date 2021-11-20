using Injector.Common;
using Injector.Common.Enums;
using Injector.Common.ISteps.B;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    public class CreateStep1B : BaseStep, ICreateStep1B<CaseDTOModelB>
    {
        public CreateStep1B(IServiceProvider service) : base(service) { }

        public OperationResult<CaseDTOModelB> Execute(OperationResult<CaseDTOModelB> caseDtoModel_IN)
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