﻿using Injector.Common.DTOModels;
using System;

namespace Injector.Core.Steps.ASteps
{
    public class CreateStep3A : BaseStep<DTOModelA>
    {
        public CreateStep3A(IServiceProvider service) : base(service) { }

        public override DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(dtoModelA);
            }

            return dtoModelA;
        }
    }
}