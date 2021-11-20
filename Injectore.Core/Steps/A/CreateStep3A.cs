using Injector.Common;
using Injector.Common.Enums;
using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class CreateStep3A : BaseStep, ICreateStep3A<CaseDTOModelA>
    {
        public CreateStep3A(IServiceProvider service) : base(service) { }

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