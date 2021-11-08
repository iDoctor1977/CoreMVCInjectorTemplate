using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseController
    {
        IWebStore ABase_WebStoreInstance { get; }
    }
}