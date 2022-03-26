using System;
using System.Collections.Generic;
using System.Linq;
using Injector.Common.Models;
using Injector.Data.Builders;
using Injector.Data.Interfaces.IRepositories;

namespace Injector.Data.Mocks
{
    public class RepositoryAMock : IRepository
    {
        private readonly IEnumerable<ReadModel> _readTransfertModels;

        public RepositoryAMock()
        {
            var builder = new EntityABuilder();
        }

        public int CreateEntity(CreateModel model)
        {
            return 1;
        }

        public ReadModel ReadEntityByGuid(Guid guid)
        {
            return _readTransfertModels.First();
        }
    }
}