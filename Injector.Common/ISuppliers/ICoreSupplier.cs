using Injector.Common.IFeatures;
using Injector.Common.IStores;

namespace Injector.Common.ISuppliers
{
    public interface ICoreSupplier
    {
        ICoreStore CoreSupplie_CoreStoreInstance { get; }

        IFeatureA GetFeatureA { get; }
        IFeatureB GetFeatureB { get; }
    }
}