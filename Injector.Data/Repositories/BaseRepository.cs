using Injector.Data.ADOModels;
using Microsoft.EntityFrameworkCore;

namespace Injector.Common.Repositories
{
    public class BaseRepository
    {
        private readonly ProjectDbContext _projectDbContext;

        public BaseRepository () {
            _projectDbContext = new ProjectDbContext();
        }

        public BaseRepository(string dbName)
        {
            _projectDbContext = new ProjectDbContext(dbName);
        }

        public BaseRepository(DbContextOptions<ProjectDbContext> options)
        {
            _projectDbContext = new ProjectDbContext(options);
        }

        public ProjectDbContext BaseRepository_DbContext => _projectDbContext;

        public int Commit()
        {
            ProjectDbContext dbContext = BaseRepository_DbContext;
            return dbContext.SaveChanges();
        }
    }
}
