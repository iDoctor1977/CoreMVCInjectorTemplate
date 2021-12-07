using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.CreateA
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep2 : ISubStep<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>>
    {
        public CreateStep1A_SubStep2(IServiceProvider service) { }

        public ICaseDTOModel<DTOModelA> Execute(ICaseDTOModel<DTOModelA> caseDtoModel_IN)
        {
            // Read

            // Do

            // Write

            return caseDtoModel_IN;
        }
    }
}