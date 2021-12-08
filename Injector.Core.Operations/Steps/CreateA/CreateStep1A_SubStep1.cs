﻿using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.ICaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep1 : ISubStep<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>>
    {
        public CreateStep1A_SubStep1(IServiceProvider service) { }

        public OperationResult<ICaseDTOModel<DTOModelA>> Execute(OperationResult<ICaseDTOModel<DTOModelA>> caseDtoModel_IN)
        {
            if (caseDtoModel_IN.Status == OperationsStatus.Success)
            {
                // Read

                // Do

                // Write
                return caseDtoModel_IN;
            }

            caseDtoModel_IN.Value.SetDTOModel(null);
            caseDtoModel_IN.Status = OperationsStatus.Error;
            caseDtoModel_IN.Message = OperationsStatus.Error.ToString();

            return caseDtoModel_IN;
        }
    }
}