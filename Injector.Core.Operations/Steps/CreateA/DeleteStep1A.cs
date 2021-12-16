using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.IActionRepositories;
using Injector.Common.ICaseDTOModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Injector.Core.Operator.Attributes;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>>
    {
        private readonly IDepotA _ia;
        public DeleteStep1A(IServiceProvider service)
        {
            _ia = service.GetRequiredService<IDepotA>();
        }

        protected override OperationResult<ICaseDTOModel<DTOModelA>> ExecuteRootStep(OperationResult<ICaseDTOModel<DTOModelA>> caseDtoModel_IN)
        {
            // Read

            // Do
            var operationResult = _ia.DeleteValue(caseDtoModel_IN.Value.GetDTOModel());

            // Write
            caseDtoModel_IN.Value.SetDTOModel(operationResult.Value);
            caseDtoModel_IN.Status = operationResult.Status;
            caseDtoModel_IN.Message = operationResult.Message;

            return caseDtoModel_IN;
        }
    }
}