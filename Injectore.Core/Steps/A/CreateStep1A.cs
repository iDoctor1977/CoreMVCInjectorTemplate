using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<CaseDTOModelA, CaseDTOModelA>
    {
        public CreateStep1A(IServiceProvider service) : base(service) { }

        protected override CaseDTOModelA ExecuteRootStep(CaseDTOModelA value)
        {
            if (BaseStep_DataSupplier.GetActionRepositoryA.CreateValue(value.GetDTOModel()))
            {
                return value;
            }

            return value;
        }
    }
}