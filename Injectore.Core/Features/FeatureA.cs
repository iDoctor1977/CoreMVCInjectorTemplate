using System;
using System.Threading.Tasks.Dataflow;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using Injector.Core.CaseDTOModels;
using Injector.Core.Steps.ASteps;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    {
        public FeatureA(IServiceProvider service) : base(service) { }

        public bool CreatePost(DTOModelA dtoModelA)
        {
            #region STEPS PIPELINE WITH TPL LIBRARY

            TransformBlock<DTOModelA, DTOModelA> step1 = new TransformBlock<DTOModelA, DTOModelA>(dtoModel => {
                CreateStep1A createStep1A = BaseFeature_CreateStep1A;
                return createStep1A.Execute(dtoModelA);
            });

            TransformBlock<DTOModelA, DTOModelA> step2 = new TransformBlock<DTOModelA, DTOModelA>(dtoModel => {
                CreateStep2A createStep2A = BaseFeature_CreateStep2A;
                return createStep2A.Execute(dtoModelA);
            });

            TransformBlock<DTOModelA, DTOModelA> step3 = new TransformBlock<DTOModelA, DTOModelA>(dtoModel => {
                CreateStep3A createStep3A = BaseFeature_CreateStep3A;
                return createStep3A.Execute(dtoModelA);
            });

            step1.LinkTo(step2);
            step2.LinkTo(step3);

            //start execution
            step1.Post(dtoModelA);

            #endregion

            CaseDTOModelA caseDTOModelsA = new CaseDTOModelA(dtoModelA);
            caseDTOModelsA.setName("nuovo nome");
            caseDTOModelsA.consolidate();
            dtoModelA = caseDTOModelsA.extractDTO();

            //dtoModelA = pipeline.Execute(dtoModelA);

            BaseFeature_DataSupplier.GetActionRepositoryA.CreateValue(dtoModelA);

            if (dtoModelA.Id != 0)
            {
                return true;
            }

            return false;
        }

        public DTOModelA DeleteGet(DTOModelA dtoModelA)
        {
            return dtoModelA;
        }

        public bool DeletePost(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelA EditGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public bool EditPost(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelA DetailsGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelA ListGet(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }
    }
}
