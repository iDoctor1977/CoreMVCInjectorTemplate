using Injector.Common.IStores;

namespace Injector.Common.IBases
{
    public interface IBaseActionRepository
    {
        IDataStore BaseActionRepository_DataStore { get; }
    }
}
