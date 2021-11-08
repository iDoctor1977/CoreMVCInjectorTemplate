using Injector.Common.ISuppliers;
using Injector.Common.IActionRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data
{
    public class DataSupplier : IDataSupplier
    {
        internal DataSupplier(ServiceProvider service) {
            service.GetRequiredService<IDataSupplier>();
        }

        #region ACTION_REPOSITORIES

        public IActionRepositoryA GetActionRepositoryA => GetActionRepositoryA; // new ActionRepositoryA()

        public IActionRepositoryB GetActionRepositoryB => GetActionRepositoryB; // new ActionRepositoryB()

        #endregion
    }
}