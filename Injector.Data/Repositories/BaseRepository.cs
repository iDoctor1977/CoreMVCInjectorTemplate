using Injector.Data.ADOModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Common.Repositories
{
    public class BaseRepository
    {
        private readonly ProjectDbContext _projectDbContext;

        public BaseRepository(IServiceProvider service) {
            _projectDbContext = service.GetRequiredService<ProjectDbContext>();
        }

        public ProjectDbContext BaseRepository_DbContext => _projectDbContext;

        public void Commit()
        {
            ProjectDbContext dbContext = BaseRepository_DbContext;
            dbContext.SaveChanges();
        }
    }
}
