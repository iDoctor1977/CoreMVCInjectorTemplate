using System;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Models;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Depots
{
    public class CreateDepot : ICreateDepot
    {
        private readonly IRepositoryA _repositoryA;

        public CreateDepot(IServiceProvider service) {
            _repositoryA = service.GetRequiredService<IRepositoryA>();
        }

        public void Execute(CreateRequestTransfertModel transfertModel)
        {
            _repositoryA.CreateEntity(transfertModel);
        }
    }
}
