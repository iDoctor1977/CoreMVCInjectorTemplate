using Injector.Common.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Common.ActionRepositories
{
    public class BaseActionRepository
    {
        private readonly RepositoryA _repositoryA;
        private readonly RepositoryB _repositoryB;

        public BaseActionRepository(IServiceProvider service) {
            _repositoryA = service.GetRequiredService<RepositoryA>();
            _repositoryB = service.GetRequiredService<RepositoryB>();
        }

        #region REPOSITORIES

        public RepositoryA GetRepositoryA => _repositoryA;

        public RepositoryB GetRepositoryB => _repositoryB;

        #endregion
    }
}
