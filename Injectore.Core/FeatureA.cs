using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
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

        public OperationResult<bool> CreatePost(DTOModelA dtoModelA)
        {
            var caseModel = new CaseDTOModelA(dtoModelA);

            // esempio di chiamata a funzione
            //caseModel = (CaseDTOModelA)_operatorSupplier.CalculatePercentualValueA(caseModel);
            //caseModel = (CaseDTOModelA)_operatorSupplier.CalculateStocasticValueA(caseModel);
            //_operatorSupplier.SplitValueA(caseModel);

            _operatorSupplier.CreateValueA(caseModel);

            var operationResult = new OperationResult<bool>
            {
                Object = true,
                Message = OperationsStatus.Success.ToString(),
                Status = OperationsStatus.Success
            };

            return operationResult;
        }

        public OperationResult<DTOModelA> DeleteGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<bool> DeletePost(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelA> EditGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<bool> EditPost(DTOModelA dtoModelA)
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
