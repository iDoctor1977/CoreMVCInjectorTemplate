using System;
using Injector.Common.Interfaces.IActionRepositories;
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

        public int CreateValue(CreateRequestTransfertModel createRequestTM)
        {
            if (_repositoryA.CreateEntity(createRequestTM) > 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
