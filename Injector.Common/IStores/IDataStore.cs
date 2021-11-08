using Injector.Common.IRepositories;

namespace Injector.Common.IStores
{
    public interface IDataStore
    {
        IRepositoryA DataRepositoryA { get; set ; }
        IRepositoryB DataRepositoryB { get; set; }
    }
}