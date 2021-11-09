using Injector.Common.IFeatures;

namespace Injector.Common.ISuppliers
{
    public interface ICoreSupplier
    {
        IFeatureA GetFeatureA { get; }
        IFeatureB GetFeatureB { get; }
    }
}