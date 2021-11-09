using Injector.Common.DTOModels;
using System;

namespace Injector.Core.Steps.ASteps
{
    public class DeleteStep2A : BaseStep<DTOModelA>
    {
        public DeleteStep2A(IServiceProvider service) : base(service) { }

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