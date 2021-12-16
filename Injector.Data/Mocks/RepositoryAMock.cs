using System.Collections.Generic;
using System.Linq;
using Injector.Data.Builders;
using Injector.Data.Entities;
using Injector.Data.IRepositories;

namespace Injector.Data.Mocks
{
    public class RepositoryAMock : IRepositoryA
    {
        private readonly IEnumerable<EntityA> _entitiesA;

        public RepositoryAMock()
        {
            var builder = new EntityABuilder();
            _entitiesA = builder.AddEntityA("Pippo").AddEntityA("pluto", "foo").Build();
        }

        public int CreateEntity(EntityA entityA)
        {
            return 1;
        }

        public int UpdateEntity(EntityA entityA)
        {
            return 1;
        }

        public EntityA ReadEntityById(int id)
        {
            return _entitiesA.First();
        }

        public EntityA ReadEntityByName(string name)
        {
            return _entitiesA.First();
        }

        public int DeleteEntity(EntityA entityA)
        {
            return 1;
        }

        public IEnumerable<EntityA> ReadEntities()
        {
            return _entitiesA;
        }
    }
}