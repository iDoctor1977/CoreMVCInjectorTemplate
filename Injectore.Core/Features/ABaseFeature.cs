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

        public ICoreStore ABase_CoreStoreInstance => ABase_CoreStoreInstance;
    }
}