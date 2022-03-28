using System;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Models;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Depots
{
    public class CreateDepot : ICreateDepot
    {
        private readonly IRepository _repository;

        public CreateDepot(IServiceProvider service) {
            _repository = service.GetRequiredService<IRepository>();
        }

        public void Execute(CreateModel model)
        {
            _repository.CreateEntity(model);
        }
    }
}
