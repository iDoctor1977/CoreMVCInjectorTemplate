using System;
using System.Collections.Generic;
using System.Linq;
using Injector.Common.Models;
using Injector.Data.Builders;
using Injector.Data.Interfaces.IRepositories;

namespace Injector.Data.Mocks
{
    public class RepositoryAMock : IRepositoryA
    {
        private readonly IEnumerable<ReadResponseTransfertModel> _readTransfertModels;

        public RepositoryAMock()
        {
            var builder = new EntityABuilder();
        }

        public int CreateEntity(CreateRequestTransfertModel transfertModel)
        {
            return 1;
        }

        public ReadResponseTransfertModel ReadEntityByGuid(Guid guid)
        {
            return _readTransfertModels.First();
        }
    }
}