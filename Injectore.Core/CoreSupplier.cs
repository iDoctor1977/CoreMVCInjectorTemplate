using Injector.Common.IFeatures;
using Injector.Common.IStores;
using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core
{
    public class CoreSupplier : ICoreSupplier
    {
        protected CoreSupplier(ServiceProvider service)
        {
            service.GetRequiredService<ICoreSupplier>();
        }

        #region FEATURES

        public IFeatureA GetFeatureA => GetFeatureA; // new FeatureA()
        public IFeatureB GetFeatureB => GetFeatureB; // new FeatureB()

        #endregion
    }
}