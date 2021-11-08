using Injector.Core;
using Injector.Common.IStores;
using Injector.Common.ISuppliers;

namespace Injector.Web
{
    public class WebStore : IWebStore
    {
        private ICoreSupplier _coreSupplier;

        #region CONSTRUCTOR

        private WebStore() { }

        private WebStore(ICoreSupplier coreSupplier)
        {
            WebStore_CoreSupplierInstance = coreSupplier;
        }

        #endregion

        #region SINGLETON

        public static IWebStore Instance()
        {
            if (WebStoreInstance == null)
            {
                WebStoreInstance = new WebStore();
            }

            return WebStoreInstance;
        }

        public static IWebStore Instance(ICoreSupplier coreSupplier)
        {
            if (WebStoreInstance == null)
            {
                WebStoreInstance = new WebStore(coreSupplier);
            }

            return WebStoreInstance;
        }

        #endregion

        private static IWebStore WebStoreInstance { get; set; }

        public ICoreSupplier WebStore_CoreSupplierInstance
        {
            get { return _coreSupplier ?? (_coreSupplier = CoreSupplier.Instance()); }
            set { _coreSupplier = value; }
        }
    }
}