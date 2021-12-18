using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;

namespace Injectore.Core
{
    public class OperationsSupplier : AOperationsSupplier
    {
        public OperationsSupplier(IServiceProvider service) : base(service) { }

        #region PIPELINE PROCEDURES

        protected override OperationResult<ICaseDTOModel<DTOModelA>> CreateValueA_Pipeline(OperationResult<ICaseDTOModel<DTOModelA>> operationResult)
        {
            operationResult = _createStep1A.AddStep(_createStep1A_SubStep1).AddStep(_createStep1A_SubStep2).Execute(operationResult);

            return operationResult;
        }

        #endregion

        #region FUNCTIONS

        protected override OperationResult<ICaseDTOModel<DTOModelA>> FuncStocasticValueA(OperationResult<ICaseDTOModel<DTOModelA>> operationResult)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
