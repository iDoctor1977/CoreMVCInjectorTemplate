using Injector.Common.IABases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.ActionRepositories
{
    public abstract class ABaseActionRepository : IABaseActionRepository
    {
        protected ABaseActionRepository(ServiceProvider service) {
            service.GetRequiredService<IDataStore>();
        }

        public IDataStore ABaseActionRepository_DataStore => ABaseActionRepository_DataStore;
    }
}
