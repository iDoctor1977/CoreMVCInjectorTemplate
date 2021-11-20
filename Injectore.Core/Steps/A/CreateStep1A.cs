using Injector.Common;
using Injector.Common.Enums;
using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class CreateStep1A : BaseStep, ICreateStep1A<CaseDTOModelA>
    {
        public CreateStep1A(IServiceProvider service) : base(service) { }

        public OperationResult<CaseDTOModelA> Execute(OperationResult<CaseDTOModelA> caseDtoModel_IN)
        {
            if (caseDtoModel_IN.Status == OperationOutcomes.Success)
            {
                // Read

                // Do
                var operationResult = BaseStep_DataSupplier.GetActionRepositoryA.CreateValue(caseDtoModel_IN.Value.GetDTOModel());

                // Write
                if (operationResult.Status == OperationOutcomes.Success)
                {
                    // caseDtoModel_OUT
                    return new OperationResult<CaseDTOModelA>
                    {
                        Value = caseDtoModel_IN.Value,
                        Message = OperationOutcomes.Success.ToString(),
                        Status = OperationOutcomes.Success
                    };
                }
            }

            return caseDtoModel_IN;
        }
    }
}