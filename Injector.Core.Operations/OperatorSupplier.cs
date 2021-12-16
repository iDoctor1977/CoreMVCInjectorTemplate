using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using System;

namespace Injector.Core.Operator
{
    public class OperatorSupplier : AOperatorSupplier
    {
        public OperatorSupplier(IServiceProvider service) : base(service) { }

        protected override OperationResult<ICaseDTOModel<DTOModelA>> CreateValueA_Pipeline(OperationResult<ICaseDTOModel<DTOModelA>> operationResult)
        {
            operationResult = _createStep1A.AddStep(_createStep1A_SubStep1).AddStep(_createStep1A_SubStep2).Execute(operationResult);

            return operationResult;
        }

        protected override OperationResult<ICaseDTOModel<DTOModelA>> FuncStocasticValueA(OperationResult<ICaseDTOModel<DTOModelA>> operationResult)
        {
            throw new NotImplementedException();
        }
    }
}
