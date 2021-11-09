using Injector.Common.IStores;

namespace Injector.Common.IBases
{
    public interface IBaseFeature
    {
        ICoreStore BaseFeature_CoreStoreInstance { get; }
    }
}