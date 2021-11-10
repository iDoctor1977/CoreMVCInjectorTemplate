using Injector.Common.DTOModels;
using Injector.Common.IBases;
using Injector.Common.IFeatures;
using System;

namespace Injector.Core.Features
{
    public class FeatureB : BaseFeature, IFeatureB
    {
        public FeatureB() : base() { }

        public FeatureB(IServiceProvider service) : base(service) { }

        #region STEPS

        public IBaseStep<DTOModelB> CreateStep1B => CreateStep1B;

        public IBaseStep<DTOModelB> CreateStep2B => CreateStep2B;

        public IBaseStep<DTOModelB> CreateStep3B => CreateStep3B;

        #endregion

        public bool CreatePost(DTOModelB dtoModelB)
        {
            // chain definition
            CreateStep1B.SetNextStep(CreateStep2B);
            CreateStep2B.SetNextStep(CreateStep3B);

            CreateStep1B.Execute(dtoModelB);

            if (dtoModelB.Id != 0)
            {
                return true;
            }

            return false;
        }

        public DTOModelB DeleteGet(DTOModelB dtoModelB)
        {
            // chain definition

            return dtoModelB;
        }

        public bool DeletePost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelB EditGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public bool EditPost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelB DetailsGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelB ListGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }
    }
}
