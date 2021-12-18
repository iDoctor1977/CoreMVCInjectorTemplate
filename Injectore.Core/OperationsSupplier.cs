using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.ICaseDTOModels;
using Injectore.Core.CaseDTOModels;

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
            if (operationResult.Value is CaseDTOModelA caseModel)
            {
                var a = 1 + 2 + 3;

                caseModel.setId(a);

                operationResult.Value = caseModel;
                operationResult.Message = OperationsStatus.Success.ToString();
                operationResult.Status = OperationsStatus.Success;
            }
            else
            {
                operationResult.Message = OperationsStatus.Error.ToString();
                operationResult.Status = OperationsStatus.Error;
            }

            return operationResult;
        }

        #endregion
    }
}
