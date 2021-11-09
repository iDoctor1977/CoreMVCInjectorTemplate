using Injector.Common.ISuppliers;

namespace Injector.Common.IStores
{
    public interface ICoreStore
    {
        IDataSupplier CoreStore_DataSupplierInstance { get; }
    }
}