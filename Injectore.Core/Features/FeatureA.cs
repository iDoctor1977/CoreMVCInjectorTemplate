using System;
using System.Threading.Tasks.Dataflow;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using Injector.Common;
using Injector.Common.Enums;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    { 
        public FeatureA(IServiceProvider service) : base(service) { }

        public OperationResult<bool> CreatePost(DTOModelA dtoModelA)
        {
            var operationResult_caseDTOModel_IN = new OperationResult<CaseDTOModelA>
            {
                Value = new CaseDTOModelA(dtoModelA),
                Status = OperationOutcomes.Success,
                Message = OperationOutcomes.Success.ToString()
            };

            #region STEPS PIPELINE WITH TPL LIBRARY

            var step1 = new TransformBlock<OperationResult<CaseDTOModelA>, OperationResult<CaseDTOModelA>>(caseDtoModel =>
            {
                ICreateStep1A<CaseDTOModelA> createStep1A = BaseFeature_CreateStep1A;
                return createStep1A.Execute(caseDtoModel);
            });

            var step2 = new TransformBlock<OperationResult<CaseDTOModelA>, OperationResult<CaseDTOModelA>>(caseDtoModel =>
            {
                ICreateStep2A<CaseDTOModelA> createStep2A = BaseFeature_CreateStep2A;
                return createStep2A.Execute(caseDtoModel);
            });

            var step3 = new TransformBlock<OperationResult<CaseDTOModelA>, OperationResult<CaseDTOModelA>>(caseDtoModel =>
            {
                ICreateStep3A<CaseDTOModelA> createStep3A = BaseFeature_CreateStep3A;
                return createStep3A.Execute(caseDtoModel);
            });

            step1.LinkTo(step2);
            step2.LinkTo(step3);

            //tart execution
            step1.Post(operationResult_caseDTOModel_IN);

            // Wait for the last block in the pipeline to process all values.
            step3.Completion.Wait();

            #endregion

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
