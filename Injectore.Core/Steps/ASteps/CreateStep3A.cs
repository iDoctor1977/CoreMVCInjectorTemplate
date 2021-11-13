using Injector.Common.DTOModels;
using System;

namespace Injector.Core.Steps.ASteps
{
    public class CreateStep3A : BaseStep
    {
        public CreateStep3A(IServiceProvider service) : base(service) { }

        public DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            return dtoModelA;
        }
    }
}