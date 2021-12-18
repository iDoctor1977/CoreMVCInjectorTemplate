using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;

namespace Injectore.Core.Interfaces
{
    public interface IOperationsSupplier
    {
        #region OPERATIONS

        public Func<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>> CreateValueAPipeline { get; }

        #endregion

        #region FUNCTIONS

        public Func<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>> CalculateStocasticValueA { get; }

        #endregion
    }
}
