using Injector.Common.IActionRepositories;
using Injector.Common.IStores;

namespace Injector.Common.ISuppliers
{
    public interface IDataSupplier
    {
        IDataStore DataSupplier_DataStoreInstance { get; set; }

        IActionRepositoryA GetActionRepositoryA { get; }
        IActionRepositoryB GetActionRepositoryB { get; }
    }
}