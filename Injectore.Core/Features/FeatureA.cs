using System;
using Injector.Common.DTOModels;
using Injector.Common.IFeatures;
using Injector.Core.CaseDTOModels;
using Injector.Core.Steps.A;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Features
{
    public class FeatureA : BaseFeature, IFeatureA
    {
        private readonly CreateStep1A _createStep1A;
        private readonly CreateStep1A_SubStep1 _createStep1A_SubStep1;
        private readonly CreateStep1A_SubStep2 _createStep1A_SubStep2;

        public FeatureA(IServiceProvider service) : base(service) { 
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep1A_SubStep1 = service.GetRequiredService<CreateStep1A_SubStep1>();
            _createStep1A_SubStep2 = service.GetRequiredService<CreateStep1A_SubStep2>();
        }

        public bool CreatePost(DTOModelA dtoModelA)
        {
            CaseDTOModelA caseDTOModelA = new CaseDTOModelA(dtoModelA);

            // pipeline
            caseDTOModelA = _createStep1A.AddStep(_createStep1A_SubStep2).AddStep(_createStep1A_SubStep2).Execute(caseDTOModelA);

            if (BaseFeature_DataSupplier.GetActionRepositoryA.CreateValue(caseDTOModelA.GetDTOModel()))
            {
                return true;
            }

            return false;
        }

        public DTOModelA DeleteGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
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
