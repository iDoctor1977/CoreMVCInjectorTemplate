using System;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.IFeatures;
using Injector.Core.CaseDTOModels;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    {
        public FeatureA(IServiceProvider service) : base(service) { }

        public OperationResult<bool> CreatePost(DTOModelA dtoModelA)
        {
            var caseModel = new CaseDTOModelA(dtoModelA);

            caseModel = (CaseDTOModelA)BaseFeature_FunctionsSupplier.CalculatePercentualValueA(caseModel);

            caseModel = (CaseDTOModelA)BaseFeature_FunctionsSupplier.CalculateStocasticValueA(caseModel);

            BaseFeature_FunctionsSupplier.SplitValueA(caseModel);

            var operationResult__OUT = new OperationResult<bool>
            {
                Value = true,
                Message = OperationOutcomes.Success.ToString(),
                Status = OperationOutcomes.Success
            };

            return operationResult__OUT;
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
