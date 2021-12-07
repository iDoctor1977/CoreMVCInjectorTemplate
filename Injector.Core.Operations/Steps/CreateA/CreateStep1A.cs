using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;
using Injector.Common.ICaseDTOModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>>
    {
        private readonly IActionRepositoryA _actionRepositoryA;
        public CreateStep1A(IServiceProvider service) {
            _actionRepositoryA = service.GetRequiredService<IActionRepositoryA>();
        }

        protected override ICaseDTOModel<DTOModelA> ExecuteRootStep(ICaseDTOModel<DTOModelA> caseDtoModel_IN)
        {
            // Read

            // Do
            var actionResult = _actionRepositoryA.CreateValue(caseDtoModel_IN.GetDTOModel());

            // Write
            return caseDtoModel_IN;
        }
    }
}