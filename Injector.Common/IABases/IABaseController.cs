using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseController
    {
        IWebStore ABaseController_WebStoreInstance { get; set; }
    }
}