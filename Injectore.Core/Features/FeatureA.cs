using System;
using Injector.Common.DTOModels;
using Injector.Common.IBases;
using Injector.Common.IFeatures;
using Injector.Core.CaseDTOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    {
        public FeatureA(ServiceProvider service) : base(service) { }

        #region STEPS
        public IBaseStep<DTOModelA> CreateStep1A => CreateStep1A;

        public IBaseStep<DTOModelA> CreateStep2A => CreateStep2A;

        public IBaseStep<DTOModelA> CreateStep3A => CreateStep3A;

        public IBaseStep<DTOModelA> DeleteStep1A => DeleteStep1A;

        public IBaseStep<DTOModelA> DeleteStep2A => DeleteStep2A;

        #endregion

        public bool CreatePost(DTOModelA dtoModelA)
        {
            // chain definition
            CreateStep1A.SetNextStep(CreateStep2A);
            CreateStep2A.SetNextStep(CreateStep3A);

            CaseDTOModelA caseDTOModelsA = new CaseDTOModelA(dtoModelA);
            caseDTOModelsA.consolidate();

            dtoModelA = CreateStep1A.Execute(dtoModelA);

            if (dtoModelA.Id != 0)
            {
                return true;
            }

            return false;
        }

        public DTOModelA DeleteGet(DTOModelA dtoModelA)
        {
            DeleteStep1A.SetNextStep(DeleteStep2A);

            dtoModelA = DeleteStep1A.Execute(dtoModelA);

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
