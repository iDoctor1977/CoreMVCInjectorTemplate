using Injector.Common.ISuppliers;
using Injector.Common.IActionRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Data
{
    public class DataSupplier : IDataSupplier
    {
        private readonly IActionRepositoryA _actionRepositoryA;
        private readonly IActionRepositoryB _actionRepositoryB;

        public DataSupplier(IServiceProvider service) {
            _actionRepositoryA = service.GetRequiredService<IActionRepositoryA>();
            _actionRepositoryB = service.GetRequiredService<IActionRepositoryB>();
        }

        #region ACTION_REPOSITORIES

        public IActionRepositoryA GetActionRepositoryA => _actionRepositoryA;

        public IActionRepositoryB GetActionRepositoryB => _actionRepositoryB;

        #endregion
    }
}