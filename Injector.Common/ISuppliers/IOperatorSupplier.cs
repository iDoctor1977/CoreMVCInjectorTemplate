using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using System;

namespace Injector.Common.ISuppliers
{
    public interface IOperatorSupplier
    {
        #region OPERATIONS

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CreateValueA { get; }

        #endregion

        #region FUNCTIONS

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> SplitValueA { get; }
        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CalculateStocasticValueA { get; }
        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CalculatePercentualValueA { get; }

        #endregion
    }
}
