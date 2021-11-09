using Injector.Common.IStores;
using Injector.Common.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Data
{
    public class DataStore : IDataStore
    {
        public DataStore(IServiceProvider service) {
            service.GetRequiredService<IDataStore>();
        }

        #region REPOSITORIES

        public IRepositoryA GetRepositoryA => GetRepositoryA;

        public IRepositoryB GetRepositoryB => GetRepositoryB;

        #endregion
    }
}