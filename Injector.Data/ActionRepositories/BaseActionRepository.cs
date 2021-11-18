using Injector.Data.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Common.ActionRepositories
{
    public class BaseActionRepository
    {
        private readonly IRepositoryA _repositoryA;
        private readonly IRepositoryB _repositoryB;

        public BaseActionRepository(IServiceProvider service) {
            _repositoryA = service.GetRequiredService<IRepositoryA>();
            _repositoryB = service.GetRequiredService<IRepositoryB>();
        }

        #region REPOSITORIES

        public IRepositoryA GetRepositoryA => _repositoryA;

        public IRepositoryB GetRepositoryB => _repositoryB;

        #endregion
    }
}
