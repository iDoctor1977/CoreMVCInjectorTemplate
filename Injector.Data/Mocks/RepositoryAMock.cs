using System.Collections.Generic;
using System.Linq;
using Injector.Data.Builders;
using Injector.Data.Entities;
using Injector.Data.IRepositories;

namespace Injector.Data.Mocks
{
    public class RepositoryAMock : IRepositoryA
    {
        private readonly IEnumerable<AEntity> _entitiesA;

        public RepositoryAMock()
        {
            var builder = new EntityABuilder();
            _entitiesA = builder.AddEntityA("faa").AddEntityA("pluto", "foo").Build();
        }

        public int CreateEntity(AEntity aEntity)
        {
            return 1;
        }

        public int UpdateEntity(AEntity aEntity)
        {
            return 1;
        }

        public AEntity ReadEntityById(int id)
        {
            return _entitiesA.First();
        }

        public AEntity ReadEntityByName(string name)
        {
            return _entitiesA.First();
        }

        public int DeleteEntity(AEntity aEntity)
        {
            return 1;
        }

        public IEnumerable<AEntity> ReadEntities()
        {
            return _entitiesA;
        }
    }
}