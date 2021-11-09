using Injector.Common.IBases;
using Injector.Common.IDbContexts;
using Injector.Data.ADOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        internal BaseRepository(ServiceProvider service) {
            service.GetRequiredService<IBaseRepository>();
        }

        public string BaseRepository_ConnectionString => BaseRepository_ConnectionString;

        public IProjectDbContext BaseRepository_DbContext => BaseRepository_DbContext;

        public void Commit()
        {
            ProjectDbContext dbContext = BaseRepository_DbContext as ProjectDbContext;
            dbContext.SaveChanges();
        }
    }
}
