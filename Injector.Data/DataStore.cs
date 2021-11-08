using Injector.Common.IStores;
using Injector.Common.IRepositories;
using Injector.Common.Repositories;
using Injector.Common.IDbContexts;

namespace Injector.Common
{
    internal class DataStore : IDataStore
    {
        string _connectionString = string.Empty;
        IProjectDbContext _projectDbContext = null;

        private IRepositoryA _repositoryA;
        private IRepositoryB _repositoryB;

        #region CONSTRUCTOR

        private DataStore() { }

        protected DataStore(IRepositoryA repositoryA)
        {
            DataRepositoryA = repositoryA;
        }

        protected DataStore(IRepositoryB repositoryB)
        {
            DataRepositoryB = repositoryB;
        }

        protected DataStore(IRepositoryA repositoryA, IRepositoryB repositoryB)
        {
            DataRepositoryA = repositoryA;
            DataRepositoryB = repositoryB;
        }

        protected DataStore(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected DataStore(IProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        protected DataStore(string connectionString, IProjectDbContext projectDbContext)
        {
            _connectionString = connectionString;
            _projectDbContext = projectDbContext;
        }

        #endregion

        #region SINGLETON

        private static IDataStore DataStoreInstance { get; set; }

        public static IDataStore Instance()
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore();
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IRepositoryA repositoryA)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(repositoryA);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IRepositoryB repositoryB)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(repositoryB);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IRepositoryA repositoryA, IRepositoryB repositoryB)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(repositoryA, repositoryB);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(string connectionString)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(connectionString);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(IProjectDbContext projectDbContext)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(projectDbContext);
            }

            return DataStoreInstance;
        }

        public static IDataStore Instance(string connectionString, IProjectDbContext projectDbContext)
        {
            if (DataStoreInstance == null)
            {
                DataStoreInstance = new DataStore(connectionString, projectDbContext);
            }

            return DataStoreInstance;
        }

        #endregion

        #region REPOSITORIES

        public IRepositoryA DataRepositoryA
        {
            get
            {
                if (_connectionString != string.Empty && _projectDbContext == null)
                {
                    return _repositoryA = RepositoryA.Instance(_connectionString);
                }
                else if (_connectionString == string.Empty && _projectDbContext != null)
                {
                    return _repositoryA = RepositoryA.Instance(_projectDbContext);
                }
                else if (_connectionString != string.Empty && _projectDbContext != null)
                {
                    return _repositoryA = RepositoryA.Instance(_connectionString, _projectDbContext);
                }
                else
                {
                    return _repositoryA = RepositoryA.Instance();
                }
            }
            set { _repositoryA = value; }
        }

        public IRepositoryB DataRepositoryB
        {
            get
            {
                if (_connectionString != string.Empty && _projectDbContext == null)
                {
                    return _repositoryB = RepositoryB.Instance(_connectionString);
                }
                else if (_connectionString == string.Empty && _projectDbContext != null)
                {
                    return _repositoryB = RepositoryB.Instance(_connectionString);
                }
                else if (_connectionString != string.Empty && _projectDbContext != null)
                {
                    return _repositoryB = RepositoryB.Instance(_connectionString, _projectDbContext);
                }
                else
                {
                    return _repositoryB = RepositoryB.Instance();
                }
            }
            set { _repositoryB = value; }
        }

        #endregion
    }
}