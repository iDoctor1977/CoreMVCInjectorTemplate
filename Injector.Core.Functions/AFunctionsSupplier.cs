using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Common.ISuppliers;
using System;

namespace Injector.Core.Functions
{
    public abstract class AFunctionsSupplier : IFunctionSupplier
    {
        public AFunctionsSupplier(IServiceProvider service) { }

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> SplitValueA => FuncSplitValueA;

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CalculateStocasticValueA => FuncStocasticValueA;

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CalculatePercentualValueA => FuncPercentualValueA;

        protected abstract ICaseDTOModel<DTOModelA> FuncSplitValueA(ICaseDTOModel<DTOModelA> caseDTOModelA);
        protected abstract ICaseDTOModel<DTOModelA> FuncStocasticValueA(ICaseDTOModel<DTOModelA> caseDTOModelA);
        protected abstract ICaseDTOModel<DTOModelA> FuncPercentualValueA(ICaseDTOModel<DTOModelA> caseDTOModelA);
    }
}
