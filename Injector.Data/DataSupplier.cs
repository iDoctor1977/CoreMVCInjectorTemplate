using Injector.Common.ISuppliers;
using Injector.Common.IActionRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Data
{
    public class DataSupplier : IDataSupplier
    {
        public DataSupplier(IServiceProvider service) {
            service.GetRequiredService<IDataSupplier>();
        }

        #region ACTION_REPOSITORIES

        public IActionRepositoryA GetActionRepositoryA => GetActionRepositoryA; // new ActionRepositoryA()

        public IActionRepositoryB GetActionRepositoryB => GetActionRepositoryB; // new ActionRepositoryB()

        #endregion
    }
}