using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class DeleteStep1A : BaseStep, IDeleteStep1A<CaseDTOModelA>
    {
        public DeleteStep1A(IServiceProvider service) : base(service) { }

        public CaseDTOModelA Execute(CaseDTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            return dtoModelA;
        }
    }
}