using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseStep<T>
    {
        ICoreStore ABaseStep_CoreStoreInstance { get; set; }
        void SetNextStep(IABaseStep<T> step);
        T Execute(T vmCreateB);
    }
}