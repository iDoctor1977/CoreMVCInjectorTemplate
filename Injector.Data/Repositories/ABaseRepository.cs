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

        public string ConnectionStringName => ConnectionStringName;

        public IProjectDbContext RepositoryDbContext => RepositoryDbContext;

        public void Commit()
        {
            ProjectDbContext dbContext = RepositoryDbContext as ProjectDbContext;
            dbContext.SaveChanges();
        }
    }
}
