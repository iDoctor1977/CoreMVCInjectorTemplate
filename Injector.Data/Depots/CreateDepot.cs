using System;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Models;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Depots
{
    public class CreateDepot : ICreateDepot
    {
        private readonly IRepository _repositoryA;

        public CreateDepot(IServiceProvider service) {
            _repositoryA = service.GetRequiredService<IRepository>();
        }

        public void Execute(CreateModel model)
        {
            _repositoryA.CreateEntity(model);
        }
    }
}
