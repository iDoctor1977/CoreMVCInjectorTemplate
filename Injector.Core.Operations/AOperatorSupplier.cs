using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Common.ISuppliers;
using Injector.Core.Operator.Steps.CreateA;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Operator
{
    public abstract class AOperatorSupplier : IOperatorSupplier
    {
        protected readonly CreateStep1A _createStep1A;
        protected readonly CreateStep1A_SubStep1 _createStep1A_SubStep1;
        protected readonly CreateStep1A_SubStep2 _createStep1A_SubStep2;

        public AOperatorSupplier(IServiceProvider service)
        {
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep1A_SubStep1 = service.GetRequiredService<CreateStep1A_SubStep1>();
            _createStep1A_SubStep2 = service.GetRequiredService<CreateStep1A_SubStep2>();
        }

        #region OPERATIONS

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CreateValueA => CreateValueA_Pipeline;

        protected abstract ICaseDTOModel<DTOModelA> CreateValueA_Pipeline(ICaseDTOModel<DTOModelA> caseDTOModelA);

        #endregion

        #region FUNCTIONS

        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> SplitValueA => FuncSplitValueA;
        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CalculateStocasticValueA => FuncStocasticValueA;
        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CalculatePercentualValueA => FuncPercentualValueA;

        protected abstract ICaseDTOModel<DTOModelA> FuncSplitValueA(ICaseDTOModel<DTOModelA> caseDTOModelA);
        protected abstract ICaseDTOModel<DTOModelA> FuncStocasticValueA(ICaseDTOModel<DTOModelA> caseDTOModelA);
        protected abstract ICaseDTOModel<DTOModelA> FuncPercentualValueA(ICaseDTOModel<DTOModelA> caseDTOModelA);

        #endregion
    }
}
