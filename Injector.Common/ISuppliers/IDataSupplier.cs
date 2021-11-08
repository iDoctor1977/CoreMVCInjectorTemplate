using Injector.Common.IActionRepositories;

namespace Injector.Common.ISuppliers
{
    public interface IDataSupplier
    {
        IActionRepositoryA GetActionRepositoryA { get; }
        IActionRepositoryB GetActionRepositoryB { get; }
    }
}