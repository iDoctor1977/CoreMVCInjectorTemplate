using Injector.Common.IBases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Common.ActionRepositories
{
    public class BaseActionRepository : IBaseActionRepository
    {
        public BaseActionRepository(IServiceProvider service) {
            service.GetRequiredService<IDataStore>();
        }

        public IDataStore BaseActionRepository_DataStore => BaseActionRepository_DataStore;
    }
}
