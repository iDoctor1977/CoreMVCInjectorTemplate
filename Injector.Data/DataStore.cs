using Injector.Common.IStores;
using Injector.Common.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data
{
    public class DataStore : IDataStore
    {
        public DataStore(ServiceProvider service) {
            service.GetRequiredService<IDataStore>();
        }

        #region REPOSITORIES

        public IRepositoryA GetRepositoryA => GetRepositoryA;

        public IRepositoryB GetRepositoryB => GetRepositoryB;

        #endregion
    }
}