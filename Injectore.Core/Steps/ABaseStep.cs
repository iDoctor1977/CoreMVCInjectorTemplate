using Injector.Common.IABases;
using Injector.Common.IStores;

namespace Injector.Core.Steps
{
    public abstract class ABaseStep<T> : IABaseStep<T>
    {
        protected IABaseStep<T> NextStep { get; private set; }
        private ICoreStore _coreStore;

        #region CONSTRUCTOR

        internal ABaseStep() { }

        internal ABaseStep(ICoreStore coreStore)
        {
            ABaseStep_CoreStoreInstance = coreStore;
        }

        #endregion

        public ICoreStore ABaseStep_CoreStoreInstance
        {
            get { return _coreStore ?? (_coreStore = CoreStore.Instance()); }
            set { _coreStore = value; }
        }

        public void SetNextStep(IABaseStep<T> nextStep)
        {
            NextStep = nextStep;
        }

        public abstract T Execute(T viewModelA);
    }
}