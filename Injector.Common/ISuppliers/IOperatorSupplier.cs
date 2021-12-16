using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using System;

namespace Injector.Common.ISuppliers
{
    public interface IOperatorSupplier
    {
        #region OPERATIONS

        public Func<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>> CreateValueA { get; }

        #endregion

        #region FUNCTIONS

        public Func<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>> CalculateStocasticValueA { get; }

        #endregion
    }
}
