using Injector.Common.IBases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Features
{
    public class BaseFeature : IBaseFeature
    {
        internal BaseFeature(ServiceProvider service)
        {
            service.GetRequiredService<ICoreStore>();
        }

        public ICoreStore BaseFeature_CoreStoreInstance => BaseFeature_CoreStoreInstance;
    }
}