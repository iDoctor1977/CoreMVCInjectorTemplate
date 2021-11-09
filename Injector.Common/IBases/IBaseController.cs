using Injector.Common.IStores;

namespace Injector.Common.IBases
{
    public interface IBaseController
    {
        IWebStore BaseController_WebStoreInstance { get; }
    }
}