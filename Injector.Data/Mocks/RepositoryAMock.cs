using System.Collections.Generic;
using System.Linq;
using Injector.Common.Models;
using Injector.Data.Builders;
using Injector.Data.Interfaces.IRepositories;

namespace Injector.Data.Mocks
{
    public class RepositoryAMock : IRepositoryA
    {
        private readonly IEnumerable<CreateResponseTransfertModel> _transfertModels;

        public RepositoryAMock()
        {
            var builder = new EntityABuilder();
        }

        public int CreateEntity(CreateRequestTransfertModel transfertModel)
        {
            return 1;
        }

        public int UpdateEntity(CreateRequestTransfertModel transfertModel)
        {
            return 1;
        }

        public CreateResponseTransfertModel ReadEntityById(int id)
        {
            return _transfertModels.First();
        }

        public CreateResponseTransfertModel ReadEntityByName(string name)
        {
            return _transfertModels.First();
        }

        public int DeleteEntity(CreateRequestTransfertModel transfertModel)
        {
            return 1;
        }

        public IEnumerable<CreateResponseTransfertModel> ReadEntities()
        {
            return _transfertModels;
        }
    }
}