using Injector.Common.IStores;

namespace Injector.Common.IBases
{
    public interface IBaseStep<T>
    {
        ICoreStore BaseStep_CoreStoreInstance { get; }

        void SetNextStep(IBaseStep<T> step);
        T Execute(T dtoModelA);
    }
}