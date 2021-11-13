using Injector.Common.DTOModels;
using System;

namespace Injector.Core.Steps.ASteps
{
    public class CreateStep2A : BaseStep
    {
        public CreateStep2A(IServiceProvider service) : base(service) { }

        public DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            return dtoModelA;
        }
    }
}