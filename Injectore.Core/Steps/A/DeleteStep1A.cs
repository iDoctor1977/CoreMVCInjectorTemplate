using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<CaseDTOModelA, CaseDTOModelA>
    {
        public DeleteStep1A(IServiceProvider service) : base(service) { }

        protected override CaseDTOModelA ExecuteRootStep(CaseDTOModelA value)
        {
            // Read

            // Do

            // Write

            return value;
        }
    }
}