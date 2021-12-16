using System.Collections.Generic;
using Injector.Data.Entities;

namespace Injector.Data.IRepositories
{
    public interface IRepositoryA
    {
        int CreateEntity(EntityA entityA);
        int UpdateEntity(EntityA entityA);
        EntityA ReadEntityById(int id);
        EntityA ReadEntityByName(string name);
        int DeleteEntity(EntityA entityA);
        IEnumerable<EntityA> ReadEntities();
    }
}