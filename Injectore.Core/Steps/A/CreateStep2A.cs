using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class CreateStep2A : BaseStep, ICreateStep2A<CaseDTOModelA>
    {
        public CreateStep2A(IServiceProvider service) : base(service) { }

        public CaseDTOModelA Execute(CaseDTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            return dtoModelA;
        }
    }
}