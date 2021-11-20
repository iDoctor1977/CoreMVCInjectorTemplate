using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using System;

namespace Injector.Core.Features
{
    public class FeatureB : BaseFeature, IFeatureB
    {
        public FeatureB(IServiceProvider service) : base(service) { }

        public OperationResult<bool> CreatePost(DTOModelB dtoModelB)
        {
            return new OperationResult<bool>
            {

            };
        }

        public OperationResult<DTOModelB> DeleteGet(DTOModelB dtoModelB)
        {
            return new OperationResult<DTOModelB>
            {

            };
        }

        public OperationResult<bool> DeletePost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelB> EditGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<bool> EditPost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelB> DetailsGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelB> ListGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }
    }
}
