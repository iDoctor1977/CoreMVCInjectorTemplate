using System;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Models;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Depots
{
    public class ReadDepot : IReadDepot
    {
        private readonly IRepositoryA _repositoryA;

        public ReadDepot(IServiceProvider service) {
            _repositoryA = service.GetRequiredService<IRepositoryA>();
        }

        public ReadModel Execute(ReadModel model)
        {
            var result = _repositoryA.ReadEntityByGuid(model.GuId);

            return result;
        }
    }
}
