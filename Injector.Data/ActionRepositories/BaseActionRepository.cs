using AutoMapper;
using Injector.Data.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Common.ActionRepositories
{
    public class BaseActionRepository
    {
        private readonly IMapper _mapper;

        private readonly IRepositoryA _repositoryA;
        private readonly IRepositoryB _repositoryB;

        public BaseActionRepository(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();

            _repositoryA = service.GetRequiredService<IRepositoryA>();
            _repositoryB = service.GetRequiredService<IRepositoryB>();
        }

        public IMapper BaseActionRepository_Mapper => _mapper;

        #region REPOSITORIES

        public IRepositoryA GetRepositoryA => _repositoryA;

        public IRepositoryB GetRepositoryB => _repositoryB;

        #endregion
    }
}
