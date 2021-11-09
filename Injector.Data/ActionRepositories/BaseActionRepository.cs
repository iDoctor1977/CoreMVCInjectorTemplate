using Injector.Common.IBases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.ActionRepositories
{
    public class BaseActionRepository : IBaseActionRepository
    {
        internal BaseActionRepository(ServiceProvider service) {
            service.GetRequiredService<IDataStore>();
        }

        public IDataStore BaseActionRepository_DataStore => BaseActionRepository_DataStore;
    }
}
