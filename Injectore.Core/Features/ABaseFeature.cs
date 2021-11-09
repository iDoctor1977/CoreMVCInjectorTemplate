using Injector.Common.IABases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Features
{
    public class ABaseFeature : IABaseFeature
    {
        internal ABaseFeature(ServiceProvider service)
        {
            service.GetRequiredService<ICoreStore>();
        }

        public ICoreStore ABaseFeature_CoreStoreInstance => ABaseFeature_CoreStoreInstance;
    }
}