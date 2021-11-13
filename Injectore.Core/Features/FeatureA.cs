using System;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using Injector.Core.CaseDTOModels;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    {
        public FeatureA(IServiceProvider service) : base(service) { }

        public bool CreatePost(DTOModelA dtoModelA)
        {
            #region STEPS PIPELINE WITH TPL LIBRARY

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
