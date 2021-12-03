using Injector.Core.Attributes;
using Injector.Common.Enums;
using Injector.Core.CaseDTOModels;
using System;
using Injector.Common;

namespace Injector.Core.Steps.A
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<OperationResult<CaseDTOModelA>, OperationResult<CaseDTOModelA>>
    {
        public CreateStep1A(IServiceProvider service) : base(service) { }

        protected override OperationResult<CaseDTOModelA> ExecuteRootStep(OperationResult<CaseDTOModelA> caseDtoModel_IN)
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