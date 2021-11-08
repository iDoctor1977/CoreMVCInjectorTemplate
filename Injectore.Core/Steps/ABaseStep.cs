using Injector.Common.IABases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Steps
{
    public abstract class ABaseStep<T> : IABaseStep<T>
    {
        protected IABaseStep<T> NextStep { get; private set; }

        internal ABaseStep(ServiceProvider service)
        {
            service.GetRequiredService(typeof(IABaseStep<>));
        }

        public ICoreStore ABaseStep_CoreStoreInstance => ABaseStep_CoreStoreInstance;

        public void SetNextStep(IABaseStep<T> nextStep)
        {
            NextStep = nextStep;
        }

        public abstract T Execute(T viewModelA);
    }
}