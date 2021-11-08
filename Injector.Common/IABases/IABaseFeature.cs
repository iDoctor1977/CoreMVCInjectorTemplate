using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseFeature
    {
        ICoreStore ABaseStore { get; set; }
    }
}