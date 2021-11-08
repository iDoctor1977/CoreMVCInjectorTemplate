using Injector.Common.IABases;
using Injector.Common.IDbContexts;
using Injector.Data.ADOModels;

namespace Injector.Common.Repositories
{
    public abstract class ABaseRepository : IABaseRepository
    {
        private string _connectionString;
        private IProjectDbContext _projectDbContext;

        #region CONSTRUCTOR

        protected ABaseRepository() { }

        protected ABaseRepository(string connectionString)
        {
            ConnectionStringName = connectionString;
        }

        protected ABaseRepository(IProjectDbContext dbContext)
        {
            RepositoryDbContext = dbContext;
        }

        protected ABaseRepository(string connectionString, IProjectDbContext dbContext)
        {
            ConnectionStringName = connectionString;
            RepositoryDbContext = dbContext;
        }

        #endregion

        public string ConnectionStringName
        {
            get { return _connectionString ?? (_connectionString = "name=ProjectDbContext"); }
            set { _connectionString = value; }
        }

        public IProjectDbContext RepositoryDbContext
        {
            get { return _projectDbContext ?? (_projectDbContext = new ProjectDbContext(ConnectionStringName)); }
            set { _projectDbContext = value; }
        }

        public void Commit()
        {
            ProjectDbContext dbContext = RepositoryDbContext as ProjectDbContext;
            dbContext.SaveChanges();
        }
    }
}
