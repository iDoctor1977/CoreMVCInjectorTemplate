using Injector.Common.DTOModels;
using System;

namespace Injector.Core.Steps.BSteps
{
    public class CreateStep2B : BaseStep<DTOModelB>
    {
        public CreateStep2B(IServiceProvider service) : base(service) { }

        public override DTOModelB Execute(DTOModelB dtoModelB)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(dtoModelB);
            }

            return dtoModelB;
        }
    }
}