using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operations.Steps.A
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<CaseDTOModelA, CaseDTOModelA>
    {
        public CreateStep1A(IServiceProvider service) : base(service) { }

        protected override CaseDTOModelA ExecuteRootStep(CaseDTOModelA caseDtoModel_IN)
        {
            // Read

            // Do
            var operationResult = BaseStep_DataSupplier.GetActionRepositoryA.CreateValue(caseDtoModel_IN.GetDTOModel());

            // Write
            return caseDtoModel_IN;
        }
    }
}