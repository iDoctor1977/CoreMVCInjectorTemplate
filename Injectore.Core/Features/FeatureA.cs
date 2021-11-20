using System;
using System.Threading.Tasks.Dataflow;
using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    { 
        public FeatureA(IServiceProvider service) : base(service) { }

        public OperationResult<bool> CreatePost(DTOModelA dtoModelA)
        {
            CaseDTOModelA caseDTOModelA = new CaseDTOModelA(dtoModelA);

            #region STEPS PIPELINE WITH TPL LIBRARY

            TransformBlock<CaseDTOModelA, CaseDTOModelA> step1 = new TransformBlock<CaseDTOModelA, CaseDTOModelA>(caseDtoModel => {
                ICreateStep1A<CaseDTOModelA> createStep1A = BaseFeature_CreateStep1A;
                return createStep1A.Execute(caseDtoModel);
            });

            TransformBlock<CaseDTOModelA, CaseDTOModelA> step2 = new TransformBlock<CaseDTOModelA, CaseDTOModelA>(caseDtoModel => {
                ICreateStep2A<CaseDTOModelA> createStep2A = BaseFeature_CreateStep2A;
                return createStep2A.Execute(caseDtoModel);
            });

            TransformBlock<CaseDTOModelA, CaseDTOModelA> step3 = new TransformBlock<CaseDTOModelA, CaseDTOModelA>(caseDtoModel => {
                ICreateStep3A<CaseDTOModelA> createStep3A = BaseFeature_CreateStep3A;
                return createStep3A.Execute(caseDtoModel);
            });

            step1.LinkTo(step2);
            step2.LinkTo(step3);

            //start execution
            step1.Post(caseDTOModelA);

            #endregion

            return new OperationResult<bool> {
                Value = BaseFeature_DataSupplier.GetActionRepositoryA.CreateValue(caseDTOModelA.GetDTOModel()),
                Status = true,
                Message = "Ok"
            };
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
