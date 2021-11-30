using Injector.Core.Attributes;
using Injector.Common.Enums;
using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<CaseDTOModelA, CaseDTOModelA>
    {
        public CreateStep1A(IServiceProvider service) : base(service) { }

        protected override OperationResult<CaseDTOModelA> ExecuteRootStep(CaseDTOModelA value)
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