using Injector.Common.IStores;
using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core
{
    public class CoreStore : ICoreStore
    {
        protected CoreStore(ServiceProvider service)
        {
            service.GetRequiredService<IDataSupplier>();
        }

        public IDataSupplier CoreStore_DataSupplierInstance => CoreStore_DataSupplierInstance;
    }
}