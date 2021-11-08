using Injector.Common;
using Injector.Common.IStores;
using Injector.Common.ISuppliers;

namespace Injector.Core
{
    internal class CoreStore : ICoreStore
    {
        private IDataSupplier _dataSupplier;

        #region CONSTRUCTOR

        protected CoreStore() { }

        protected CoreStore(IDataSupplier dataSupplier)
        {
            CoreStore_DataSupplierInstance = dataSupplier;
        }

        #endregion

        #region SINGLETON

        private static ICoreStore CoreStoreIstance { get; set; }

        public static ICoreStore Instance()
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore();
            }

            return CoreStoreIstance;
        }

        public static ICoreStore Instance(IDataSupplier dataSupplier)
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore(dataSupplier);
            }

            return CoreStoreIstance;
        }

        #endregion

        public IDataSupplier CoreStore_DataSupplierInstance
        {
            get { return _dataSupplier ?? (_dataSupplier = DataSupplier.Instance()); }
            set { _dataSupplier = value; }
        }
    }
}