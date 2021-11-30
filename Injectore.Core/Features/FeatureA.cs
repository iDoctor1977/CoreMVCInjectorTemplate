using System;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using Injector.Core.CaseDTOModels;
using Injector.Core.Steps.A;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    {
        private readonly CreateStep1A _createStep1A;
        private readonly CreateStep1A_SubStep1 _createStep1A_SubStep1;
        private readonly CreateStep1A_SubStep2 _createStep1A_SubStep2;

        public FeatureA(IServiceProvider service) : base(service) { 
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep1A_SubStep1 = service.GetRequiredService<CreateStep1A_SubStep1>();
            _createStep1A_SubStep2 = service.GetRequiredService<CreateStep1A_SubStep2>();
        }

        public OperationResult<bool> CreatePost(DTOModelA dtoModelA)
        {
            var operationResult_caseDTOModel_IN = new OperationResult<CaseDTOModelA>
            {
                Value = new CaseDTOModelA(dtoModelA),
                Status = OperationOutcomes.Success,
                Message = OperationOutcomes.Success.ToString()
            };

            // pipeline
            caseDTOModelA = _createStep1A.AddStep(_createStep1A_SubStep2).AddStep(_createStep1A_SubStep2).Execute(caseDTOModelA);

            var operationResult__OUT = new OperationResult<bool>
            {
                Value = Convert.ToBoolean(operationResult_caseDTOModel_IN.Status),
                Message = operationResult_caseDTOModel_IN.Message,
                Status = operationResult_caseDTOModel_IN
                .Status
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
