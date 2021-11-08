using Injector.Common.ISuppliers;
using Injector.Common.ActionRepositories;
using Injector.Common.IActionRepositories;
using Injector.Common.IStores;

namespace Injector.Common
{
    public class DataSupplier : IDataSupplier
    {
        private IDataStore _dataStore;

        private IActionRepositoryA _actionRepositoryA;
        private IActionRepositoryB _actionRepositoryB;

        #region CONSTRUCTOR

        internal DataSupplier() { }

        internal DataSupplier(IDataStore dataStore)
        {
            DataSupplier_DataStoreInstance = dataStore;
        }

        #endregion

        #region SINGLETON

        private static IDataSupplier DataSupplierInstance { get; set; }

        public static IDataSupplier Instance()
        {
            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = new DataSupplier();
            }

            return DataSupplierInstance;
        }

        public static IDataSupplier Instance(IDataStore dataStore)
        {
            if (DataSupplierInstance == null)
            {
                DataSupplierInstance = new DataSupplier(dataStore);
            }

            return DataSupplierInstance;
        }

        #endregion

        public IDataStore DataSupplier_DataStoreInstance
        {
            get { return _dataStore ?? (_dataStore = DataStore.Instance()); }
            set { _dataStore = value; }
        }

        #region ACTION_REPOSITORIES

        public IActionRepositoryA GetActionRepositoryA => _actionRepositoryA ?? (_actionRepositoryA = ActionRepositoryA.Instance(DataSupplier_DataStoreInstance)); // new ActionRepositoryA()

        public IActionRepositoryB GetActionRepositoryB => _actionRepositoryB ?? (_actionRepositoryB = ActionRepositoryB.Instance(DataSupplier_DataStoreInstance)); // new ActionRepositoryB()

        #endregion
    }
}