using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;
using Injector.Common.ICaseDTOModels;
using Injectore.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.CreateA
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>>
    {
        private readonly IDepotA _depotA;
        public DeleteStep1A(IServiceProvider service)
        {
            _depotA = service.GetRequiredService<IDepotA>();
        }

        protected override OperationResult<ICaseDTOModel<DTOModelA>> ExecuteRootStep(OperationResult<ICaseDTOModel<DTOModelA>> caseDtoModelIn)
        {
            // Read

            // Do

            // Write

            return caseDtoModelIn;
        }
    }
}