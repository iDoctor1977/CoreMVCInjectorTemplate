using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.ICaseDTOModels;
using Injectore.Core.Attributes;

namespace Injectore.Core.Steps.CreateA
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep1 : ISubStep<OperationResult<ICaseDTOModel<DTOModelA>>, OperationResult<ICaseDTOModel<DTOModelA>>>
    {
        public CreateStep1A_SubStep1(IServiceProvider service) { }

        public OperationResult<ICaseDTOModel<DTOModelA>> Execute(OperationResult<ICaseDTOModel<DTOModelA>> caseDtoModelIn)
        {
            if (caseDtoModelIn.Status == OperationsStatus.Success)
            {
                // Read

                // Do

                // Write
                return caseDtoModelIn;
            }

            caseDtoModelIn.Value.SetDTOModel(null);
            caseDtoModelIn.Status = OperationsStatus.Error;
            caseDtoModelIn.Message = OperationsStatus.Error.ToString();

            return caseDtoModelIn;
        }
    }
}