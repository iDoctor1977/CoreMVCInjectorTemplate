using Injector.Common.IABases;
using Injector.Common.IDbContexts;
using Injector.Data.ADOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.Repositories
{
    public abstract class ABaseRepository : IABaseRepository
    {
        protected ABaseRepository(ServiceProvider service) {
            service.GetRequiredService<IABaseRepository>();
        }

        public string ABaseRepository_ConnectionString => ABaseRepository_ConnectionString;

        public IProjectDbContext ABaseRepository_DbContext => ABaseRepository_DbContext;

        public void Commit()
        {
            ProjectDbContext dbContext = ABaseRepository_DbContext as ProjectDbContext;
            dbContext.SaveChanges();
        }
    }
}
