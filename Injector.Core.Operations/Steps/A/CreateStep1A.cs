using Injector.Common.IActionRepositories;
using Injector.Core.CaseDTOModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Operator.Steps.A
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<CaseDTOModelA, CaseDTOModelA>
    {
        private readonly IActionRepositoryA _actionRepositoryA;
        public CreateStep1A(IServiceProvider service) {
            _actionRepositoryA = service.GetRequiredService<IActionRepositoryA>();
        }

        protected override CaseDTOModelA ExecuteRootStep(CaseDTOModelA caseDtoModel_IN)
        {
            // Read

            // Do
            var actionResult = _actionRepositoryA.CreateValue(caseDtoModel_IN.GetDTOModel());

            // Write
            return caseDtoModel_IN;
        }
    }
}