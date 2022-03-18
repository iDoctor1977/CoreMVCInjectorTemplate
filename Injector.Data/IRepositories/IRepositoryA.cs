using System.Collections.Generic;
using Injector.Data.Entities;

namespace Injector.Data.IRepositories
{
    public interface IRepositoryA
    {
        int CreateEntity(AEntity aEntity);
        int UpdateEntity(AEntity aEntity);
        AEntity ReadEntityById(int id);
        AEntity ReadEntityByName(string name);
        int DeleteEntity(AEntity aEntity);
        IEnumerable<AEntity> ReadEntities();
    }
}