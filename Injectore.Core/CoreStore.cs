using Injector.Common.IStores;
using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core
{
    public class CoreStore : ICoreStore
    {
        public CoreStore(IServiceProvider service)
        {
            service.GetRequiredService<IDataSupplier>();
        }

        public IDataSupplier CoreStore_DataSupplierInstance => CoreStore_DataSupplierInstance;
    }
}