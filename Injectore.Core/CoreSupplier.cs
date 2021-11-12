using Injector.Common.IFeatures;
using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core
{
    public class CoreSupplier : ICoreSupplier
    {
        private readonly IFeatureA _featureA;
        private readonly IFeatureB _featureB;

        public CoreSupplier(IServiceProvider service) {
            _featureA = service.GetRequiredService<IFeatureA>();
            _featureB = service.GetRequiredService<IFeatureB>();
        }

        #region FEATURES

        public IFeatureA GetFeatureA => _featureA; //new FeatureA()
        public IFeatureB GetFeatureB => _featureB; //new FeatureB()

        #endregion
    }
}