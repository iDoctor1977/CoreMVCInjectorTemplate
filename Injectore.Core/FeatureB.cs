﻿using Injector.Common;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using System;

namespace Injector.Core
{
    public class FeatureB : IFeatureB
    {
        public FeatureB(IServiceProvider service) { }

        public OperationResult<bool> CreatePost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<DTOModelB> DeleteGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
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
