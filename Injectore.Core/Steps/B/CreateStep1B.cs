using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    [Root]
    public class CreateStep1B : RootPipelineBuilder<CaseDTOModelB, CaseDTOModelB>
    {
        public CreateStep1B(IServiceProvider service) : base(service) { }

        protected override CaseDTOModelB ExecuteRootStep(CaseDTOModelB value)
        {
            // Read

            // Do

            // Write

            throw new NotImplementedException();
        }
    }
}