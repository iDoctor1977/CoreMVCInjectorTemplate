﻿using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.IActionRepositories;
using Injector.Common.ICaseDTOModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Injector.Core.Operator.Attributes;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>>
    {
        private readonly IDepotA _ia;
        public DeleteStep1A(IServiceProvider service)
        {
            _ia = service.GetRequiredService<IDepotA>();
        }

        protected override OperationResult<ICaseDTOModel<DTOModelA>> ExecuteRootStep(OperationResult<ICaseDTOModel<DTOModelA>> caseDtoModelIn)
        {
            // Read

            // Do
            var operationResult = _ia.DeleteValue(caseDtoModelIn.Value.GetDTOModel());

            // Write
            caseDtoModelIn.Value.SetDTOModel(operationResult.Value);
            caseDtoModelIn.Status = operationResult.Status;
            caseDtoModelIn.Message = operationResult.Message;

            return caseDtoModelIn;
        }
    }
}