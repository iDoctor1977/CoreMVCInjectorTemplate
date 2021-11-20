using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using System;

namespace Injector.Core.Features
{
    public class FeatureB : BaseFeature, IFeatureB
    {
        public FeatureB(IServiceProvider service) : base(service) { }

        public OperetionResult<bool> CreatePost(DTOModelB dtoModelB)
        {
            return new OperetionResult<bool>
            {

            };
        }

        public OperetionResult<DTOModelB> DeleteGet(DTOModelB dtoModelB)
        {
            return new OperetionResult<DTOModelB>
            {

            };
        }

        public OperetionResult<bool> DeletePost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperetionResult<DTOModelB> EditGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperetionResult<bool> EditPost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperetionResult<DTOModelB> DetailsGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperetionResult<DTOModelB> ListGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }
    }
}
