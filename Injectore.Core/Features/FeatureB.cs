using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using System;

namespace Injector.Core.Features
{
    public class FeatureB : BaseFeature, IFeatureB
    {
        public FeatureB(IServiceProvider service) : base(service) { }

        public bool CreatePost(DTOModelB dtoModelB)
        {
            // chain definition

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
