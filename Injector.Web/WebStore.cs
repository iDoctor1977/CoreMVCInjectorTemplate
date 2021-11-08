using Injector.Common.IStores;
using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web
{
    public class WebStore : IWebStore
    {
        public WebStore(ServiceProvider service)
        {
            service.GetRequiredService<IWebStore>();
        }

        public ICoreSupplier WebStore_CoreSupplierInstance
        {
            get { return WebStore_CoreSupplierInstance; }
        }
    }
}