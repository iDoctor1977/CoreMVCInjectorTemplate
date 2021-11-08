using Injector.Common.IDbContexts;
using Injector.Common.IRepositories;

namespace Injector.Common.IStores
{
    public interface IDataStore
    {
        IRepositoryA GetRepositoryA { get; }
        IRepositoryB GetRepositoryB { get; }
    }
}