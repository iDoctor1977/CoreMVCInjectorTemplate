using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;
using Injector.Common.ICaseDTOModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>>
    {
        private readonly IActionRepositoryA _actionRepositoryA;
        public CreateStep1A(IServiceProvider service) {
            _actionRepositoryA = service.GetRequiredService<IActionRepositoryA>();
        }

        protected override OperationResult<ICaseDTOModel<DTOModelA>> ExecuteRootStep(OperationResult<ICaseDTOModel<DTOModelA>> caseDtoModel_IN)
        {
            // Read

            // Do
            var operationResult = _actionRepositoryA.CreateValue(caseDtoModel_IN.Value.GetDTOModel());

            // Write
            caseDtoModel_IN.Value.SetDTOModel(operationResult.Value);
            caseDtoModel_IN.Status = operationResult.Status;
            caseDtoModel_IN.Message = operationResult.Message;

            return caseDtoModel_IN;
        }
    }
}