using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.ICaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>>
    {
        public DeleteStep1A(IServiceProvider service) { }

        protected override OperationResult<ICaseDTOModel<DTOModelA>> ExecuteRootStep(OperationResult<ICaseDTOModel<DTOModelA>> caseDtoModel_IN)
        {
            if (caseDtoModel_IN.Status == OperationsStatus.Success)
            {
                // Read

                // Do

                // Write
            }

            return caseDtoModel_IN;
        }
    }
}