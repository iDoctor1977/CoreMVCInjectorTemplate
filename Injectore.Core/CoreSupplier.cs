using Injector.Common.IFeatures;
using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core
{
    public class CoreSupplier : ICoreSupplier
    {
        public CoreSupplier(IServiceProvider service)
        {
            service.GetRequiredService<ICoreSupplier>();
        }

        #region FEATURES

        public IFeatureA GetFeatureA => GetFeatureA; // new FeatureA()
        public IFeatureB GetFeatureB => GetFeatureB; // new FeatureB()

        #endregion
    }
}