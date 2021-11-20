using Injector.Common;
using Injector.Common.Enums;
using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class CreateStep2A : BaseStep, ICreateStep2A<CaseDTOModelA>
    {
        public CreateStep2A(IServiceProvider service) : base(service) { }

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