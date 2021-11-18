using System.Collections.Generic;
using Injector.Data.ADOModels;

namespace Injector.Data.IRepositories
{
    public interface IRepositoryB
    {
        int CreateEntity(EntityB entityB);
        int UpdateEntity(EntityB entityB);
        EntityB ReadEntityById(int id);
        EntityB ReadEntityByUsername(string username);
        int DeleteEntity(EntityB entityB);
        IEnumerable<EntityB> ReadEntities();
    }
}