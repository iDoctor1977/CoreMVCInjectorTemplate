using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using Injector.Common.IFeatures;
using Injector.Common.ISuppliers;
using Injector.Core.CaseDTOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core
{
    public class FeatureA : IFeatureA
    {
        private readonly IOperatorSupplier _operatorSupplier;

        public FeatureA(IServiceProvider service) {
            _operatorSupplier = service.GetRequiredService<IOperatorSupplier>();
        }

        public OperationResult<DTOModelA> CreatePost(DTOModelA dtoModelA)
        {
            var caseModelA = new CaseDTOModelA(dtoModelA);
            var operationResult = new OperationResult<ICaseDTOModel<DTOModelA>>(caseModelA);

            // esempio di chiamata a funzione
            //caseModel = (CaseDTOModelA)_operatorSupplier.CalculatePercentualValueA(caseModel);
            //caseModel = (CaseDTOModelA)_operatorSupplier.CalculateStocasticValueA(caseModel);
            //_operatorSupplier.SplitValueA(caseModel);

            operationResult = _operatorSupplier.CreateValueA(operationResult);

            var createPostResult = new OperationResult<DTOModelA>
            {
                Value = operationResult.Value.GetDTOModel(),
                Message = operationResult.Message,
                Status = operationResult.Status
            };

            return createPostResult;
        }

        public OperationResult<DTOModelA> DeleteGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelA> DeletePost(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelA> EditGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelA> EditPost(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelA> DetailsGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelA> ListGet(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }
    }
}
