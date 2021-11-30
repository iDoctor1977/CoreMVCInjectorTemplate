using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Functions
{
    public class FunctionsSupplier : AFunctionsSupplier
    {
        public FunctionsSupplier(IServiceProvider service) : base(service) { }

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
