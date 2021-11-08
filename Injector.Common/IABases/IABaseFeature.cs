using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseFeature
    {
        ICoreStore ABase_CoreStoreInstance { get; }
    }
}