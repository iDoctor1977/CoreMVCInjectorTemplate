using Injector.Common.IStores;

namespace Injector.Common.IABases
{
    public interface IABaseActionRepository
    {
        IDataStore ABase_DataStore { get; set; }
    }
}
