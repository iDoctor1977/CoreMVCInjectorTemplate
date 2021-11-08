using Injector.Common.IABases;
using Injector.Common.IStores;

namespace Injector.Common.ActionRepositories
{
    public abstract class ABaseActionRepository : IABaseActionRepository
    {
        private IDataStore _dataStore;

        #region CONSTRUCTOR

        protected ABaseActionRepository() { }

        protected ABaseActionRepository(IDataStore dataStore)
        {
            ABase_DataStore = dataStore;
        }

        #endregion

        public IDataStore ABase_DataStore
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }
    }
}
