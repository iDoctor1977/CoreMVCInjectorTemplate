using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Common.IFeatures;
using Injectore.Core.CaseDTOModels;
using Injectore.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Features
{
    public class FeatureA : IFeatureA
    {
        private readonly IOperationsSupplier _operationsSupplier;

        public FeatureA(IServiceProvider service) {
            _operationsSupplier = service.GetRequiredService<IOperationsSupplier>();
        }

        public OperationResult<DTOModelA> CreateAndAddNewValueA(DTOModelA dtoModelA)
        {
            var caseModelA = new CaseDTOModelA(dtoModelA);
            var operationResult = new OperationResult<ICaseDTOModel<DTOModelA>>(caseModelA);

            // esempio di chiamata a funzione
            //caseModel = (CaseDTOModelA)_operationsSupplier.CalculatePercentualValueA(caseModel);
            //caseModel = (CaseDTOModelA)_operationsSupplier.CalculateStocasticValueA(caseModel);
            //_operationsSupplier.SplitValueA(caseModel);

            operationResult = _operationsSupplier.CreateValueAPipeline(operationResult);

            var createPostResult = new OperationResult<DTOModelA>
            {
                Value = operationResult.Value.GetDTOModel(),
                Message = operationResult.Message,
                Status = operationResult.Status
            };

            return createPostResult;
        }
    }
}
