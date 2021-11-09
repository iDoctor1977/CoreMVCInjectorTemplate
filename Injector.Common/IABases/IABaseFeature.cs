using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseFeature
    {
        ICoreStore ABaseFeature_CoreStoreInstance { get; }
    }
}