using System;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Models;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Depots
{
    public class ReadDepot : IReadDepot
    {
        private readonly IRepository _repository;

        public ReadDepot(IServiceProvider service) {
            _repository = service.GetRequiredService<IRepository>();
        }

        public ReadModel Execute(ReadModel model)
        {
            var result = _repository.ReadEntityByGuid(model.Guid);

            return result;
        }
    }
}
