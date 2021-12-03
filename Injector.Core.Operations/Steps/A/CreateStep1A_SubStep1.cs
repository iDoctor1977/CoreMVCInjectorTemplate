﻿using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.A
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep1 : ISubStep<CaseDTOModelA, CaseDTOModelA>
    {
        public CreateStep1A_SubStep1(IServiceProvider service) { }

        public CaseDTOModelA Execute(CaseDTOModelA caseDtoModel_IN)
        {
            // Read

            // Do

            // Write

            return caseDtoModel_IN;
        }
    }
}