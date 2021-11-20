using Injector.Common;
using Injector.Common.Enums;
using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class DeleteStep2A : BaseStep, IDeleteStep2A<CaseDTOModelA>
    {
        public DeleteStep2A(IServiceProvider service) : base(service) { }

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