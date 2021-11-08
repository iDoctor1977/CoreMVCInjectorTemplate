using Injector.Common.ISuppliers;

namespace Injector.Common.IStores
{
    public interface IWebStore
    {
        ICoreSupplier WebStore_CoreSupplierInstance { get; }
    }
}