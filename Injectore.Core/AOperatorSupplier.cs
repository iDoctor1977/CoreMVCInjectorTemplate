﻿using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injectore.Core.Interfaces;
using Injectore.Core.Steps.CreateA;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core
{
    internal abstract class AOperatorSupplier : IOperatorSupplier
    {
        protected readonly CreateStep1A _createStep1A;
        protected readonly CreateStep1A_SubStep1 _createStep1A_SubStep1;
        protected readonly CreateStep1A_SubStep2 _createStep1A_SubStep2;

        protected AOperatorSupplier(IServiceProvider service)
        {
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep1A_SubStep1 = service.GetRequiredService<CreateStep1A_SubStep1>();
            _createStep1A_SubStep2 = service.GetRequiredService<CreateStep1A_SubStep2>();
        }

        #region PIPELINE PROCEDURES

        public Func<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>> CreateValueAPipeline => CreateValueA_Pipeline;

        protected abstract OperationResult<ICaseDTOModel<DTOModelA>> CreateValueA_Pipeline(OperationResult<ICaseDTOModel<DTOModelA>> caseDTOModelA);

        #endregion

        #region FUNCTIONS

        public Func<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>> CalculateStocasticValueA => FuncStocasticValueA;

        protected abstract OperationResult<ICaseDTOModel<DTOModelA>> FuncStocasticValueA(OperationResult<ICaseDTOModel<DTOModelA>> caseDTOModelA);

        #endregion
    }
}
