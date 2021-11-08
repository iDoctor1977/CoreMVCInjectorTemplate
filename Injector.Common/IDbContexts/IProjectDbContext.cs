using Injector.Common.IEntities;
using Microsoft.EntityFrameworkCore;

namespace Injector.Common.IDbContexts
{
    public interface IProjectDbContext
    {
        DbSet<IEntityA> EntitiesA { get; set; }
        DbSet<IEntityB> EntitiesB { get; set; }
        DbSet<IEntityC> EntitiesC { get; set; }
    }
}