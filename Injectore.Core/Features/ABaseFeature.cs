using Injector.Common.IABases;
using Injector.Common.IStores;

namespace Injector.Core.Features
{
    public class ABaseFeature : IABaseFeature
    {
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseFeature() { }

        internal ABaseFeature(ICoreStore coreStore)
        {
            ABaseStore = coreStore;
        }

        #endregion

        public ICoreStore ABaseStore
        {
            get { return _coreStore ?? (_coreStore = CoreStore.Instance()); }
            set { _coreStore = value; }
        }
    }
}