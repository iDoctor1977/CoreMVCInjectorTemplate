using Injector.Core.Attributes;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    [Leaf(nameof(DeleteStep1A))]
    public class DeleteStep1A_SubStep1 : BaseStep, ISubStep<CaseDTOModelA, CaseDTOModelA>
    {
        public DeleteStep1A_SubStep1(IServiceProvider service) : base(service) { }

        public CaseDTOModelA Execute(CaseDTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            return dtoModelA;
        }
    }
}