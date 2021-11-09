using Injector.Common.DTOModels;
using System;

namespace Injector.Core.Steps.ASteps
{
    public class DeleteStep1A : BaseStep<DTOModelA>
    {
        public DeleteStep1A(IServiceProvider service) : base(service) { }

        public override DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                dtoModelA = NextStep.Execute(dtoModelA);
            }

            return dtoModelA;
        }
    }
}