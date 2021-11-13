using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class CreateStep3A : BaseStep, ICreateStep3A<CaseDTOModelA>
    {
        public CreateStep3A(IServiceProvider service) : base(service) { }

        public CaseDTOModelA Execute(CaseDTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            return dtoModelA;
        }
    }
}