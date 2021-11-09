using System.Collections.Generic;
using Injector.Common.IABases;
using Injector.Common.IEntities;

namespace Injector.Common.IRepositories
{
    public interface IRepositoryA : IABaseRepository
    {
        int CreateEntity(IEntityA entityA);
        bool UpdateEntity(IEntityA entityA);
        IEntityA ReadEntityById(int id);
        bool DeleteEntity(IEntityA entityA);
        IEnumerable<IEntityA> ReadEntities();
    }
}