using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator
{
    public class OperatorSupplier : AOperatorSupplier
    {
        public OperatorSupplier(IServiceProvider service) : base(service) { }

        protected override ICaseDTOModel<DTOModelA> CreateValueA_Pipeline(ICaseDTOModel<DTOModelA> caseDTOModelA)
        {
            caseDTOModelA = _createStep1A.AddStep(_createStep1A_SubStep1).AddStep(_createStep1A_SubStep2).Execute(caseDTOModelA);

            return caseDTOModelA;
        }

        protected override ICaseDTOModel<DTOModelA> FuncPercentualValueA(ICaseDTOModel<DTOModelA> caseDTOModelA)
        {
            throw new NotImplementedException();
        }

        protected override ICaseDTOModel<DTOModelA> FuncSplitValueA(ICaseDTOModel<DTOModelA> caseDTOModelA)
        {
            throw new NotImplementedException();
        }

        protected override ICaseDTOModel<DTOModelA> FuncStocasticValueA(ICaseDTOModel<DTOModelA> caseDTOModelA)
        {
            throw new NotImplementedException();
        }
    }
}
