using Injector.Core.Features;
using Injector.Common.IFeatures;
using Injector.Common.IStores;
using Injector.Common.ISuppliers;

namespace Injector.Core
{
    public class CoreSupplier : ICoreSupplier
    {
        private ICoreStore _coreStore;

        private IFeatureA _featureA;
        private IFeatureB _featureB;

        #region CONSTRUCTOR

        protected CoreSupplier() { }

        protected CoreSupplier(ICoreStore coreStore)
        {
            CoreSupplie_CoreStoreInstance = coreStore;
        }

        #endregion

        #region SINGLETON

        private static ICoreSupplier CoreSupplierInstance { get; set; }

        public static ICoreSupplier Instance()
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier();
            }

            return CoreSupplierInstance;
        }

        public static ICoreSupplier Instance(ICoreStore coreStore)
        {
            if (CoreSupplierInstance == null)
            {
                CoreSupplierInstance = new CoreSupplier(coreStore);
            }

            return CoreSupplierInstance;
        }

        #endregion

        public ICoreStore CoreSupplie_CoreStoreInstance
        {
            get { return _coreStore ?? (_coreStore = Core.CoreStore.Instance()); }
            set { _coreStore = value; }
        }

        #region FEATURES

        public IFeatureA GetFeatureA => _featureA ?? (_featureA = FeatureA.Instance(CoreSupplie_CoreStoreInstance)); // new FeatureA()
        public IFeatureB GetFeatureB => _featureB ?? (_featureB = FeatureB.Instance(CoreSupplie_CoreStoreInstance)); // new FeatureB()

        #endregion
    }
}