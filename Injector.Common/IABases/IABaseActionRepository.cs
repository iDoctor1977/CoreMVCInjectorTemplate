using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseActionRepository
    {
        IDataStore ABaseActionRepository_DataStore { get; }
    }
}
