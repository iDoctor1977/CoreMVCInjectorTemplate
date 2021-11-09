using Injector.Common.DTOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Steps.ASteps
{
    public class DeleteStep2A : BaseStep<DTOModelA>
    {
        public DeleteStep2A(ServiceProvider service) : base(service) { }

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