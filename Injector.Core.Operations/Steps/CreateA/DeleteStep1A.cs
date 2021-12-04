﻿using Injector.Common;
using Injector.Common.Enums;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<OperationResult<CaseDTOModelA>, OperationResult<CaseDTOModelA>>
    {
        public DeleteStep1A(IServiceProvider service) { }

        protected override OperationResult<CaseDTOModelA> ExecuteRootStep(OperationResult<CaseDTOModelA> caseDtoModel_IN)
        {
            if (caseDtoModel_IN.Status == OperationsStatus.Success)
            {
                // Read

                // Do

                // Write
            }

            return caseDtoModel_IN;
        }
    }
}