using Injector.Common.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Data
{
    public class DataStore
    {
        private readonly RepositoryA _repositoryA;
        private readonly RepositoryB _repositoryB;

        public DataStore(IServiceProvider service) {
            _repositoryA = service.GetRequiredService<RepositoryA>();
            _repositoryB = service.GetRequiredService<RepositoryB>();
        }

        #region REPOSITORIES

        public RepositoryA GetRepositoryA => _repositoryA;

        public RepositoryB GetRepositoryB => _repositoryB;

        #endregion
    }
}